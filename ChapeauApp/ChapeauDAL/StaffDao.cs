using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class StaffDao : BaseDao
    {
        public List<Employee> GetUserNameAndPassword(string userName, string hashPassword)
        {
            string query = "SELECT UserName, Password, Role, EmployeeID FROM EMPLOYEE" +
                            "WHERE userName = @UserName AND hashPassword = @hashPassword" ;

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", userName),
                new SqlParameter("@EndDate", hashPassword)
            };
            DataTable dataTable = ExecuteSelectQuery(query, parameters);
            return ReadTables(dataTable);

        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> tables = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Employee table = new Employee()
                {
                    EmployeeID = (int)row["EmployeeID"],
                    UserName = row["UserName"].ToString(),
                    Password = (int)row["Password"],
                    Role = (int)row["Role"]
                };
                tables.Add(table);
            }
            return tables;
        }
       
        
    }
}
