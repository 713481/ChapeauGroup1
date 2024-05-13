using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int ItemID { get; set; }
        public int OrderID { get; set; }
        public int OrderCount { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
