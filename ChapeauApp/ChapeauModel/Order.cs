using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public Table TableID { get; set; }
        public int EmployeeID { get; set; }
        public List<OrderItem> OrderList { get; set; }
        public ItemStatus Status { get; set; }
        public DateTime OrderTime { get; set; }

        public TimeSpan CustomerWaitingTime
        {
            get
            {
                return DateTime.Now - OrderTime;
            }
        }
       
    }
}
