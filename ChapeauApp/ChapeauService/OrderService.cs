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

        public void ChangeStatus(OrderItem orderItem, ItemStatus statusToChange)
        {
            orderDao.ChangeStatus(orderItem, statusToChange);
        }

        public void OrderStatusUpdate(int orderId, ItemStatus orderStatus) 
        {
           orderDao.OrderStatusUpdate(orderId, orderStatus);
        }

        public void GetOrderItem(bool isABar, bool isAOpenOrders, int id)
        {
            orderDao.GetOrderItems(isABar, isAOpenOrders, id);
        }

        public List<Order> GetOrder(bool bar, bool openOrder)
        {
            return orderDao.GetOrders(bar, openOrder);
        }

        public void GetHistoryOrderItem(int tableid)
        {
            orderDao.GetHistoryOrderItems(tableid);
        }
    }
}
