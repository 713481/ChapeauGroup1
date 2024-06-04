using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int ItemID { get; set; }
        public int Stock {  get; set; }
        public MenuType MenuType { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal VAT { get; set; }
        public ItemCategory Category { get; set; }
    }
}
