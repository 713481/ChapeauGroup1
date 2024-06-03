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
        private readonly StaffDao staffDao;

        public StaffService()
        {
            staffDao = new StaffDao();
        }
        //adding method 
        public List<Employee> GetUserNameAndPassword(string userName, string hashPassword)
        {
            return staffDao.GetUserNameAndPassword(userName, hashPassword);
        }
        public bool CheckUserNameExist(string username)
        {
            return staffDao.CheckUserName(username);
        }
        public string HashPasword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
      
    }
    
}
