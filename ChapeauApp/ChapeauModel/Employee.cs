﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Password { get; set; }
        public StaffRole Role { get; set; }
        public string UserName { get; set; }
        public string HashedPassword { get; set; } // convert from Password to HashedPassword
    }
}
