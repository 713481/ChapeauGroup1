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
            string query = "UPDATE [Orderitem] " +
                   "SET [ItemStatus] = @Status";

            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
            new SqlParameter("@Status", (int)changeStatus),
            new SqlParameter("@ItemID", item.MenuItem.ItemID)
            };

            // Check if the notes are not empty, then include the description in the query and parameters
            if (!string.IsNullOrEmpty(item.Notes))
            {
                query += ", [OrderDescription] = @Description";
                sqlParameters.Add(new SqlParameter("@Description", item.Notes));
            }

            // Add the WHERE clause to specify the item to update
            query += " WHERE ItemID = @ItemID";

            // Execute the query with the constructed SQL string and parameters
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
                    //ItemID = (int)dr["ItemID"],
                    OrderID = (int)dr["OrderID"],
                    StatusItem = (ItemStatus)dr["ItemStatus"],
                    OrderCount = (int)dr["OrderCount"],
                    Notes = dr["OrderDescription"].ToString(),
                    OrderTime = (DateTime)dr["OrderTime"],
                };
            list.Add(orderItem);
            }
            return list;
        }

        public List<OrderItem> GetOrderItems(bool isABar, bool isAOpenOrders, int orderId) 
        {
            string query = "SELECT OI.OrderID, OI.ItemID, OI.OrderCount, OI.ItemStatus, OI.OrderDescription, OI.OrderTime " +
                  "FROM [Orderitem] AS OI " +
                  "JOIN [MENUITEM] AS M ON M.ItemID = OI.ItemID " +
                  "WHERE OI.OrderID = @OrderID ";
            if (isABar)
            {
                query += "AND M.MealsType = 3 ";
            }
            else
            {
                query += "AND M.MealsType != 3 ";
            }

            if (!isAOpenOrders)
            {
                query += "AND OI.ItemStatus > 2";
            }
            else
            {
                query += "AND OI.ItemStatus <= 2";
            }
            query += "ORDER BY M.CategoryType, OI.OrderTime";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderId)
            };

            return ReadOrderItemTables(ExecuteSelectQuery(query, sqlParameters));

        }

        public void OrderStatusUpdate(int orderID, OrderStatus status)
        {
            string query = "UPDATE [Orderitem]" +
                           "SET OrderStatus = @orderStatus" +
                           "WHERE OrderID = @orderID";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            {
                new SqlParameter("@orderStatus", status);
                new SqlParameter("@order", orderID);
            };
            ExecuteEditQuery(query, sqlParameters.ToArray());
        }

    

        public List<Order> GetOrders(bool isBar, bool isOpenOrders)
        {
            string query = "SELECT O.OrderID, O.TableID, O.OrderTime " +  //MAX(O.OrderStatus) AS OrderStatus
                "FROM [ORDER] AS O " +
                "JOIN [OrderItem] AS OI ON O.OrderID = OI.OrderID " +
                "JOIN [MENUITEM] AS MI ON OI.ItemID = MI.ItemID ";  // Join with MENUITEM table

            // Append conditions based on isBar
            if (isBar)
            {
                // For bar orders, consider only orders with MealType 3 (drinks)
                query += "WHERE MI.MealsType = 3";
            }
            else
            {
                // For kitchen orders, consider only orders with MealType 1 or 2 (food)
                query += "WHERE MI.MealsType IN (1, 2)";
            }
            if (isOpenOrders)
            {
                query += " AND OI.ItemStatus <= 2"; ////////////////////////////////Change it to OI.OrderStatus
            }
            else
            {
                query += " AND CAST(GETDATE() AS date) = CAST(O.OrderTime AS date) " +            //get orders from the same day
                         "AND O.OrderID NOT IN (SELECT DISTINCT OrderID " +                    //closed orders will be grouped together
                                                "FROM [Orderitem] AS OI " +
                                                "JOIN [MENUITEM] AS I ON OI.ItemID = I.ItemID " +
                                                "WHERE ItemStatus <= 2 " +
                                                "AND MealsType ";
                if (!isBar)
                {
                    query += "!= 3";
                }
                else
                {
                    query += "= 3";
                }
            }

            // Group by all non-aggregated columns
            query += " GROUP BY O.OrderID, O.TableID, O.OrderTime";

            // Order the results by OrderTime
            query += " ORDER BY O.OrderTime";
            return ReadOrderTables(ExecuteSelectQuery(query), isBar, isOpenOrders);
           
        }

 

        private List<Order> ReadOrderTables(DataTable dataTable, bool isBar, bool isOpenOrders)
       {
          List<Order> listOforder = new List<Order>();
          List<int> listOrderId = new List<int>();

         int tableOrderID;

            foreach (DataRow dr in dataTable.Rows)
             {
                tableOrderID = (int)dr["orderID"];

                if (listOrderId.Contains(tableOrderID))
                    continue;

                Order order = new Order()
                {
                    OrderID = tableOrderID,
                    //Table = tableDao.GetTableById((int)dr["tableID"]),
                    TableID = (int)dr["tableID"],
                    OrderTime = (DateTime)dr["OrderTime"],
                };
               listOrderId.Add(tableOrderID);
                order.OrderList = GetOrderItems(isBar, isOpenOrders, order.OrderID);
                listOforder.Add(order);
            }
            return listOforder;
        }

        public List<Order> GetHistoryOrders(OrderStatus status, bool isBar, bool isOpenOrders)
        {
            // Define the SQL query to retrieve orders within the specified date range
            string query = @"SELECT OrderID, TableID, OrderTime
                     FROM [ORDER]
                     WHERE OrderStatus = @orderStatus";

            // Create parameters for the start and end date
            SqlParameter[] parameters = {
             new SqlParameter("@orderStatus", status),
            };

            // Execute the query and retrieve the results
            DataTable resultTable = ExecuteSelectQuery(query, parameters);
            List<Order> historyOrders = new List<Order>();
            List<int> listOrderId = new List<int>();
            int tableOrderID;


            // Process the result table
            foreach (DataRow row in resultTable.Rows)
            {
                tableOrderID = (int)row["orderID"];

                if (listOrderId.Contains(tableOrderID))
                    continue;
                // Create an Order object and populate its properties
                Order order = new Order
                {
                    OrderID = (int)row["OrderID"],
                    TableID = (int)row["TableID"],
                    OrderTime = (DateTime)row["OrderTime"]
                };

                // Add the Order object to the list
                listOrderId.Add(tableOrderID);
                order.OrderList = GetOrderItems(isBar, isOpenOrders, order.OrderID);
                historyOrders.Add(order);
            }

            return historyOrders;
        }

    }
}
