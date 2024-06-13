using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderDetail
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public int OrderCount { get; set; }
        public DateTime OrderTime { get; set; }
        public int ItemStatus { get; set; }
        public string OrderDescription { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal VAT { get; set; }
        public OrderStatus orderStatus {  get; set; } 
    }
}
