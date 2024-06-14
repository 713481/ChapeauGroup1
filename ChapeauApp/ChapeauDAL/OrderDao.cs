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
            string query = "INSERT INTO [Order] (TableID, EmployeeID, OrderTime) OUTPUT INSERTED.OrderID VALUES (@TableID, @EmployeeID, @OrderTime)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableID", order.TableID),
                new SqlParameter("@EmployeeID", order.EmployeeID),
                new SqlParameter("@OrderTime", DateTime.Now)
            };
            return ExecuteInsertQuery(query, sqlParameters);
        }
        // Add an item to an existing order
        public void AddOrderItem(OrderItem orderItem)
        {
            string query = "INSERT INTO [OrderItem] (ItemID, OrderID, OrderCount, OrderTime, ItemStatus, OrderDescription) VALUES (@ItemID, @OrderID, @OrderCount, @OrderTime, @ItemStatus, @OrderDescription)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ItemID", orderItem.MenuItem.ItemID),
                new SqlParameter("@OrderID", orderItem.OrderID),
                new SqlParameter("@OrderCount", orderItem.OrderCount),
                new SqlParameter("@OrderTime", orderItem.OrderTime),
                new SqlParameter("@ItemStatus", (int)orderItem.StatusItem),
                new SqlParameter("@OrderDescription", orderItem.Notes)
            };
            ExecuteEditQuery(query, sqlParameters);

            // Update MenuItem stock
            string updateStockQuery = "UPDATE MENUITEM SET Stock = Stock - 1 WHERE ItemID = @ItemID";
            SqlParameter[] updateStockParams = new SqlParameter[]
            {
                new SqlParameter("@ItemID", orderItem.MenuItem.ItemID)
            };

            ExecuteEditQuery(updateStockQuery, updateStockParams);
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
                    ItemName = dr["ItemName"].ToString(),
                };
            list.Add(orderItem);
            }
            return list;
        }

        public List<OrderItem> GetOrderItems(bool isABar, bool isAOpenOrders, int orderId) 
        {
            string query = "SELECT OI.OrderID, OI.ItemID, OI.OrderCount, OI.ItemStatus, OI.OrderDescription, OI.OrderTime, M.ItemName " +
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
            string query = "UPDATE [Order] " +
                    "SET [OrderStatus] = @orderStatus " +
                    "WHERE OrderID = @orderID";

            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
               new SqlParameter("@orderStatus", (int)status), 
               new SqlParameter("@orderID", orderID)
            };
            ExecuteEditQuery(query, sqlParameters.ToArray());
        }

    

        public List<Order> GetOrders(bool isBar, bool isOpenOrders)
        {
            string query = @"
              SELECT O.OrderID, O.TableID, O.OrderTime
              FROM [ORDER] AS O
             JOIN [OrderItem] AS OI ON O.OrderID = OI.OrderID
             JOIN [MENUITEM] AS MI ON OI.ItemID = MI.ItemID
             WHERE ";

            // Append conditions based on isBar
            if (isBar)
            {
                query += "MI.MealsType = 3"; // For bar orders, consider only drinks
            }
            else
            {
                query += "MI.MealsType IN (1, 2)"; // For kitchen orders, consider only food
            }

            // Append conditions based on isOpenOrders
            if (isOpenOrders)
            {
                query += " AND OrderStatus <= 2"; // Only open orders
                query += " AND CAST(GETDATE() AS date) = CAST(O.OrderTime AS date)"; // Only orders from the same day
            }
            else
            {
                if (!isBar)
                {
                    query += " AND MI.MealsType != 3"; // Exclude drinks for kitchen orders
                }
            }

            // Group by all non-aggregated columns and order by OrderTime
                query += @"
               GROUP BY O.OrderID, O.TableID, O.OrderTime
               ORDER BY O.OrderTime";

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
            string query = @"
            SELECT OrderID, TableID, OrderTime
            FROM [ORDER]
            WHERE 
            OrderStatus = @orderStatus
            AND CAST(OrderTime AS date) = CAST(GETDATE() AS date)";

            // Create parameters for the order status
            SqlParameter[] parameters = {
        new SqlParameter("@orderStatus", (int)status)
    };

            // Execute the query and retrieve the results
            DataTable resultTable = ExecuteSelectQuery(query, parameters);
            List<Order> historyOrders = new List<Order>();

            // Process the result table
            foreach (DataRow row in resultTable.Rows)
            {
                // Create an Order object and populate its properties
                Order order = new Order
                {
                    OrderID = (int)row["OrderID"],
                    TableID = (int)row["TableID"],
                    OrderTime = (DateTime)row["OrderTime"]
                };

                // Add the Order object to the list
                order.OrderList = GetOrderItems(isBar, isOpenOrders, order.OrderID);
                historyOrders.Add(order);
            }

            return historyOrders;
        }

        //OrderDao--Iskren Dobrev--------------------------------------------------------------------------------------------------------------------------------------------------------- 
        public List<OrderDetail> GetUnpaidOrderDetailsByTableNumber(int tableID)
        {
            string query = @"
                SELECT oi.ItemId, oi.OrderID, oi.OrderCount, oi.OrderTime, oi.ItemStatus, oi.OrderDescription, 
                       mi.ItemName, mi.Price, mi.VAT
                FROM OrderItem oi
                JOIN [ORDER] o ON oi.OrderID = o.OrderID
                JOIN MENUITEM mi ON oi.ItemId = mi.ItemId
                WHERE o.TableID = @TableID AND o.OrderStatus != @OrderStatus";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableID", tableID),
                new SqlParameter("@OrderStatus", (int)OrderStatus.Paid)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadOrderDetails(dataTable);
        }

        private List<OrderDetail> ReadOrderDetails(DataTable dataTable)
        {
            var orderDetails = new List<OrderDetail>();

            foreach (DataRow row in dataTable.Rows)
            {   
                OrderDetail detail = new OrderDetail
                {
                    ItemId = Convert.ToInt32(row["ItemId"]),
                    OrderId = Convert.ToInt32(row["OrderID"]),
                    OrderCount = Convert.ToInt32(row["OrderCount"]),
                    OrderTime = Convert.ToDateTime(row["OrderTime"]),
                    ItemStatus = Convert.ToInt32(row["ItemStatus"]),
                    OrderDescription = row["OrderDescription"].ToString(),
                    ItemName = row["ItemName"].ToString(),
                    Price = Convert.ToDecimal(row["Price"]),
                    VAT = Convert.ToDecimal(row["VAT"])
                };
                orderDetails.Add(detail);
            }

            return orderDetails;
        }
    }
}
