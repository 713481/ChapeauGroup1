using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ChapeauService
{
    public class StaffService
    {
        StaffDao staffDao;
      
        public StaffService()
        {

            staffDao = new StaffDao();
        
        }
        //adding method 
        //method to get employee data based on username and password
        public Employee GetUserNameAndPassword(string userName, string password)
        {
            // ... hash the password before querying the database 
            string hashPassword = HashPassword(password);

            return staffDao.GetUserNameAndPassword(userName, hashPassword);

        }
        //method to hash and store password for all users 
        public void HashAndStorePasswords()
        {
            List<Employee> employees = staffDao.GetEmployees();

            foreach (Employee employee in employees)
            {
                string hashedPassword = HashPassword(employee.Password);
                staffDao.UpdatePassword(employee.UserName, hashedPassword);
            }
        }
       //a helper method to hash a password using SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        //method to create user with a hashed password
        public void CreateUser(string userName, string password)
        {
            string hashedPassword = HashPassword(password);
            staffDao.CreateUser(userName, hashedPassword);
            staffDao.UpdatePassword(userName, hashedPassword);
        }
        public void CreateMultipleUsers()
        {
            StaffService staffService = new StaffService();
            staffService.CreateUser("John", "12334");

        }


    }
    
}
