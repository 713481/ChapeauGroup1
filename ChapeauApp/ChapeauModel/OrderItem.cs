﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public MenuItem MenuItem { get; set; }
        public int OrderID { get; set; }
        public int OrderCount { get; set; }
        public DateTime OrderTime { get; set; }

        public ItemStatus StatusItem { get; set; }
        public string Notes { get; set; }

        public int tableID {  get; set; }
        public TimeSpan WaitingTime
        {
            get
            {
                return DateTime.Now - OrderTime;
            }
        }

    }
}
