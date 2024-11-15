﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public int TableID { get; set; }
        public int EmployeeID { get; set; }
        public List<OrderItem> OrderList { get; set; }
        public Table Table { get; set; }
        //public OrderStatus OrderStatus { get; set; }
        public TimeSpan CustomerWaitingTime
        {
            get
            {
                return DateTime.Now - OrderTime;
            }
        }
        public DateTime OrderTime { get; set; }
       public OrderStatus orderStatus { get; set; }
    }
}
