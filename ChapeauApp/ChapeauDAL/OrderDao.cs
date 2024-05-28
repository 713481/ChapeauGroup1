using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        ItemDao itemDao;
        TableDao tableDao;
        public OrderDao() 
        { 
            itemDao = new ItemDao();
            tableDao = new TableDao();
        }
        //Order
       
        private List<Order> ReadOrderTables(DataTable dataTable, bool bar, bool openOrders)
        {
            List<int> orderInt = new List<int>();
            List<Order> listOfOrders = new List<Order>();

            int tableid;

            foreach (DataRow dr in dataTable.Rows)
            {
                tableid = (int)dr["orderID"];

                if (orderInt.Contains(tableid))
                    continue;

                Order order = new Order()
                {
                    OrderID = tableid,
                    TableID = tableDao.GetTableById((int)dr["TableID"]),
                };
                orderInt.Add(tableid);
                order.OrderList = GetOrderItems(bar, openOrders, order.OrderID);
                listOfOrders.Add(order);
            }
            return listOfOrders;
        }
        public List<Order> GetOrders(bool bar, bool openOrders)
        {
            string query = "SELECT O.OrderID, TableID" +
                           "FROM [ORDER] AS O " +
                           "JOIN [OrderItem] AS OI ON O.OrderID = OI.OrderID " +
                           "JOIN [MENUITEM] AS MI ON OI.ItemID = MI.itemID " +
                           "WHERE MealsType ";

            query += (bar) ? "= 3" : "!= 3";      //  This part help seperate between Bar And Kitcehn

            if (openOrders)
                query += " AND OI.OrderStatus <= 2";
            else
            {
                query += " AND CAST(GETDATE() AS date) = CAST(OrderTime AS date) " +            //  cast date and set current date
                          "AND O.OrderID NOT IN (SELECT DISTINCT OrderID " +                    //  finding completely closed orders
                                                "FROM [OrderItem] AS OI " +
                                                "JOIN [MENUITEM] AS MI ON OI.itemID = MI.itemID " +
                                                "WHERE OrderStatus <= 2 " +
                                                "AND MealsType ";

                query += (bar) ? "= 3) " : "!= 3) ";      //  shis part seperate between Bar And Kitcehn
            }
            query += "GROUP BY O.OrderID, TableID, OrderTime " +
                     "ORDER BY OI.OrderTime";

            return ReadOrderTables(ExecuteSelectQuery(query), bar, openOrders);
        }


        private List<OrderItem> ReadOrderItems(DataTable dataTable)  //
        {
            ItemDao item = new ItemDao();
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderID = (int)dr["OrderID"],
                    StatusItem = (ItemStatus)dr["OrderStatus"],
                    OrderTime = (DateTime)dr["OrderTime"],
                    tableID = (int)dr["TableID"]
                };
                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        public List<OrderItem> GetHistoryOrderItems(int tableID)      //
        {
            string query = "SELECT OI.OrderID, OI.OrderStatus, OI.OrderTime, O.TableID " +
                           "FROM [Orderitem] AS OI " +
                           "JOIN [ORDER] AS O ON OI.OrderID = O.OrderID " +
                           $"WHERE OI.OrderStatus = 3 AND O.TableID = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[]
           {
                new SqlParameter("@tableId", tableID)
           };

            DataTable dataTable = ExecuteSelectQuery(query);

            return ReadOrderItems(dataTable);
        }



        //This Part is for Ordering Item
        public void ChangeStatus(OrderItem item, ItemStatus changeStatus) //It update the OrderStatus 
        {
            string query = "UPDATE [Orderitem]" +
                           "SET [OrderStatus] = @Status" +
                           "WHERE OrderID = @OrderID AND ItemID = @ItemID AND OrderDescription ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@Status", (int)changeStatus),
                new SqlParameter("@OrderID", item.OrderID),
                new SqlParameter("@ItemID", item.MenuItem.ItemID)
            };
            if (item.Notes != "")
            {
                query = query + "@Description";
                sqlParameters.Add(new SqlParameter("@Description", item.Notes));
            }
            ExecuteEditQuery(query, sqlParameters.ToArray());
        }

        private List<OrderItem> ReadOrderItemTables(DataTable tableOfData)
        {
            List<OrderItem> list = new List<OrderItem>();
            foreach (DataRow dr in tableOfData.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    MenuItem = itemDao.GetItemById((int)dr["ItemID"]),
                    OrderID = (int)dr["OrderID"],
                    StatusItem = (ItemStatus)dr["OrderStatus"],
                    OrderCount = (int)dr["OrderCount"],
                    Notes = dr["OrderDescription"].ToString(),
                    OrderTime = (DateTime)dr["OrderTime"],
                };
            list.Add(orderItem);
            }
            return list;
        }

        public List<OrderItem> GetOrderItems(bool isABar, bool isAOpenOrders, int id) 
        {
            string query = "SELECT OrderID, " +
                           "FROM [Orderitem] AS OI" +
                           "JOIN [MENUITEM] AS M ON M.ItemID = OI.ItemID" +
                           "WHERE orderID = @OrderID AND OrderStatus";
            query += (isABar) ? "AND MealsType = 3" : "AND MealsType !=3";
            query += (isAOpenOrders) ? "<= 2" : ">2 ";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return ReadOrderItemTables(ExecuteSelectQuery(query, sqlParameters));

        }

        public void OrderStatusUpdate(int orderID, ItemStatus status)
        {
            string query = "UPDATE [Orderitem]" +
                           "SET OrderStatus = @orderStatus" +
                           "WHERE OrderID = @orderID";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            {
                new SqlParameter("@orderStatus", (int)status);
                new SqlParameter("@order", orderID);
            };
            ExecuteEditQuery(query, sqlParameters.ToArray());
        }

        //My Part
        public List<Order> GetOrders(Order order)
        {
            string query = "SELECT OrderID, TableID, EmployeeID, OrderTime, OrderStatus FROM [ORDER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable) 
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["OrderID"],
                    TableID = (Table)dr["TableID"],
                    EmployeeID = (int)dr["EmployeeID"],
                    OrderTime = (DateTime)dr["OrderTime"],
                    Status = (ItemStatus)dr["OrderStatus"],
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
