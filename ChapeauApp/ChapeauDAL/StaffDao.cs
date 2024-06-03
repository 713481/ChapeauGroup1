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
            string query = "SELECT UserName, Password, Role, EmployeeID FROM EMPLOYEE " +
                           "WHERE UserName = @UserName AND Password = @HashPassword";

            SqlParameter[] parameters = {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@HashPassword", hashPassword)
            };
            DataTable dataTable = ExecuteSelectQuery(query, parameters);
            return ReadTables(dataTable);

        }
      
        public bool CheckUserName(string username)
        {
            string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE UserName = @UserName";
            int result = Convert.ToInt32(ExecuteScalar(query, command =>
            {
                command.Parameters.AddWithValue("@UserName", username);
            }));

            return result > 0;
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeID = (int)row["EmployeeID"],
                    UserName = row["UserName"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = (StaffRole)row["Role"]
                };
                employees.Add(employee);
            }
            return employees;
        }
       
        
    }
}
