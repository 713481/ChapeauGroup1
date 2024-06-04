using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Bill
    {
        public int BillID { get; set; }
        public int OrderID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime BillDate { get; set; }
        public string PaymentMethod { get; set; }
        public double Tip { get; set; }
        public string Feedback { get; set; }
    }
}
