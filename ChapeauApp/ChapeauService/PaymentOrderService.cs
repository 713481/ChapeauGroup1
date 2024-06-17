using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;
using System.Data.SqlClient;

namespace ChapeauService
{
    public class PaymentOrderService
    {
        private string connectionString;
        private OrderDao orderDao; //OrderDao to interact with the database

        public PaymentOrderService()
        {
            orderDao = new OrderDao(); // Initializes data access object
        }

        public List<OrderDetail> GetOrderDetailsByTableNumber(int tableNumber)
        {
            //fetch order details based on table number
            return orderDao.GetUnpaidOrderDetailsByTableNumber(tableNumber);
        }

       
    }
}
