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
                            "SET TableStatus = @tableStatus " +
                            "WHERE TableNumber = @tableNumber";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@TableStatus", tableStatus),
                new SqlParameter("@TableNumber", tableNumber)
            };

            ExecuteEditQuery(query, sqlParameters.ToArray());
        }
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

   

    }
}
