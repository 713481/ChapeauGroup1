using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ChapeauDAL
{
    public class StaffDao : BaseDao
    {
        public void CreateUser(string userName, string hashedPassword)
        {
            string query = "INSERT INTO EMPLOYEE (UserName, Password) VALUES (@UserName, @Password)";
            SqlParameter[] parameters = {
            new SqlParameter("@UserName", userName),
            new SqlParameter("@Password", hashedPassword)
        };

            ExecuteEditQuery(query, parameters);
        }
        public Employee GetUserNameAndPassword(string userName, string hashedPassword)
        {
            string query = "SELECT UserName, Password, NewRole, EmployeeID FROM EMPLOYEE " +
                           "WHERE UserName = @UserName AND Password = @HashedPassword";

            SqlParameter[] parameters = {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@HashedPassword", hashedPassword) 
            };
            DataTable dataTable = ExecuteSelectQuery(query, parameters);
            return ReadTables(dataTable);

        }
         
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string query = "SELECT UserName, Password FROM EMPLOYEE";
            SqlParameter[] parameters = new SqlParameter[0]; 
            DataTable dataTable = ExecuteSelectQuery(query, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add(new Employee
                {
                    UserName = row["UserName"].ToString(),
                    Password = row["Password"].ToString()
                });
            }

            return employees;
        }
        public void UpdatePassword(string userName, string hashedPassword)
        {
            string query = "UPDATE EMPLOYEE SET Password = @HashedPassword WHERE UserName = @UserName";
            SqlParameter[] parameters = {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@HashedPassword", hashedPassword)
            };
            ExecuteEditQuery(query, parameters);
        }

        private Employee ReadTables(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
                return null;

            DataRow row = dataTable.Rows[0];

            return new Employee()
            {
                EmployeeID = (int)row["EmployeeID"],
                UserName = row["UserName"].ToString(),
                HashedPassword = row["Password"].ToString(),
                Role = (StaffRole)Enum.Parse(typeof(StaffRole), row["NewRole"].ToString(), true)
            };
        }



    }
}
