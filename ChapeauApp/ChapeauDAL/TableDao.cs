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
        public void UpdatesTableStatus(int tableNumber, int tableStatus)
        {
            string query = "UPDATE [TABLE]" +
                            "SET tableStatus = @TableStatus" +
                            "WHERE tableNumber = @TableNumber";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@TableStatus", tableStatus),
                new SqlParameter("@TableNumber", tableNumber)
            };

            ExecuteEditQuery(query, sqlParameters.ToArray());
        }










    }   
}
