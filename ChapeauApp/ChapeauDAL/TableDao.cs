using ChapeauModel;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        //method to get all tables
        public List<Table> GetTables()
        {
            string query = "SELECT TableID, TableNumber, TableStatus FROM [TABLE]";
            DataTable dataTable = ExecuteSelectQuery(query, new SqlParameter[0]);
            return ReadTables(dataTable);

        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow row in dataTable.Rows) 
            {
                Table table = new Table()
                {
                    TableID = (int)row["TableID"],
                    TableNumber = (int)row["TableNumber"],
                    TableStatus = (int)row["TableStatus"]
                };
                tables.Add(table);
            }
            return tables;
        }
        //method to update table status 
        public void UpdatesTableStatus(int tableNumber, int tableStatus)
        {
            string query = "UPDATE [TABLE]" +
                            "SET TableStatus = @tableStatus " +
                            "WHERE TableNumber = @tableNumber";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@TableStatus", tableStatus),
                new SqlParameter("@TableNumber", tableNumber)
            };

            ExecuteEditQuery(query, sqlParameters.ToArray());
        }
        //method to get a specific table 
        public Table GetTableNUmbers(int tableNumber)
        {
            string query = "SELECT TableID, TableNumber, TableStatus FROM [Table] WHERE TableNumber = @tableNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", tableNumber);
            List<Table> tables = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            if (tables.Count > 0)
            {
                return tables[0];
            }
            else
            {
                return null;
            }
        }
        //getting order items..........................
        //method to get item ordered by table number for the current date
        public List<OrderItem> GetItemsOrderByTable(int tableNumber)
        {
            string query =
                        "SELECT oi.ItemID, oi.OrderID, oi.OrderTime, oi.ItemStatus " +
                        "FROM OrderItem oi " +
                         "JOIN [Order] o ON oi.OrderID = o.OrderID " +
                         "WHERE o.TableID = @TableNumber AND CONVERT(date, oi.OrderTime) = CONVERT(date,GETDATE())" ;
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNumber", tableNumber)
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    ItemID = (int)row["ItemID"],
                    StatusItem = (ItemStatus)row["ItemStatus"],
                    OrderTime = (DateTime)row["OrderTime"],
                    OrderID = (int)row["OrderID"]


                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        //method to update the status of item
        public void UpdateOrderItemStatus(int itemID, ItemStatus status)
        {
            string query = "UPDATE OrderItem SET ItemStatus = @Status WHERE ItemID = @ItemID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Status", (int)status),
                new SqlParameter("@ItemID", itemID)
            };
            ExecuteEditQuery(query, sqlParameters);
        }


    }
}
