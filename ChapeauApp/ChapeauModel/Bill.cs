using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    internal class Bill
    {
        public int BillID { get; set; }
        public int OrderID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime BillDate { get; set; }
    }
}
