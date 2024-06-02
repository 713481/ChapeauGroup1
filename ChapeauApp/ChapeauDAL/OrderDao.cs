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
        //-Order-Alex-----------------------------------------------------------------------------------------------------------------------------------------------------------
        // Creating an order
        public int CreateOrder(Order order)
        {
            string query = "INSERT INTO [Order] (TableID, EmployeeID, OrderDate) OUTPUT INSERTED.OrderID VALUES (@TableID, @EmployeeID, @OrderDate)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableID", order.TableID),
                new SqlParameter("@EmployeeID", order.EmployeeID),
                new SqlParameter("@OrderDate", DateTime.Now)
            };
            return ExecuteInsertQuery(query, sqlParameters);
        }
        // Add an item to an existing order
        public void AddOrderItem(OrderItem orderItem)
        {
            string query = "INSERT INTO [OrderItem] (OrderID, ItemID, OrderCount, OrderStatus, OrderDescription, OrderTime) VALUES (@OrderID, @ItemID, @OrderCount, @OrderStatus, @OrderDescription, @OrderTime)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderItem.OrderID),
                new SqlParameter("@ItemID", orderItem.MenuItem.ItemID),
                new SqlParameter("@OrderCount", orderItem.OrderCount),
                new SqlParameter("@OrderStatus", (int)orderItem.StatusItem),
                new SqlParameter("@OrderDescription", orderItem.Notes),
                new SqlParameter("@OrderTime", DateTime.Now)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        // Get orders by table ID
        public List<Order> GetOrdersByTable(int tableId)
        {
            string query = "SELECT OrderID, TableID, EmployeeID FROM [Order] WHERE TableID = @TableID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableID", tableId)
            };
            return ReadOrderTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadOrderTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)row["OrderID"],
                    TableID = (int)row["TableID"],
                    EmployeeID = (int)row["EmployeeID"]
                };
                orders.Add(order);
            }
            return orders;
        }
        //-OrderItem----Ro Bben-------------------------------------------------------------------------------------------------------------------------------------------------
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
    }
}
