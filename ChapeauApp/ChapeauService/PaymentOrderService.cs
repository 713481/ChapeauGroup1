using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class PaymentOrderService
    {
        private OrderDao orderDao; // Assuming you have an OrderDao to interact with the database

        public PaymentOrderService()
        {
            orderDao = new OrderDao(); // Initialize your data access object
        }

        public List<OrderDetail> GetOrderDetailsByTableNumber(int tableNumber)
        {
            // Implement the method to fetch order details based on table number
            return orderDao.GetOrderDetailsByTableNumber(tableNumber);
        }
    }
}
