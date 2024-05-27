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

        //OrderItem
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
