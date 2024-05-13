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
        public string MenuType { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int VAT { get; set; }
    }
}
