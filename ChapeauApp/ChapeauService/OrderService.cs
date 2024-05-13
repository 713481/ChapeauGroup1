using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDao orderDao;
        public OrderService() 
        { 
            orderDao = new OrderDao(); 
        }
        // Below are the added methods
    }
}
