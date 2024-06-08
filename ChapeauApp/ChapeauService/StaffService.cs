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
        public Employee GetUserNameAndPassword(string userName, string password)
        {
            // ... hash
            string hashPassword = HashPassword(password);

            return staffDao.GetUserNameAndPassword(userName, hashPassword);

        }
        public void HashAndStorePasswords()
        {
            List<Employee> employees = staffDao.GetEmployees();

            foreach (Employee employee in employees)
            {
                string hashedPassword = HashPassword(employee.Password);
                staffDao.UpdatePassword(employee.UserName, hashedPassword);
            }
        }
       
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        public void CreateUser(string userName, string password)
        {
            string hashedPassword = HashPassword(password);
            staffDao.CreateUser(userName, hashedPassword);
        }
        public void CreateMultipleUsers()
        {
            StaffService staffService = new StaffService();
            

        }


    }
    
}
