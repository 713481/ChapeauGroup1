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
        // Alex
        private OrderDao orderDao;
        public OrderService() 
        { 
            orderDao = new OrderDao(); 
        }
        public int CreateOrder(Order order)
        {
            return orderDao.CreateOrder(order);
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            orderDao.AddOrderItem(orderItem);
        }
        public List<Order> GetOrdersByTable(int tableId)
        {
            return orderDao.GetOrdersByTable(tableId);
        }
        // Ro Bben
        public void ChangeStatus(OrderItem orderItem, ItemStatus statusToChange)
        {
            orderDao.ChangeStatus(orderItem, statusToChange);
        }

        public void OrderStatusUpdate(int orderId, ItemStatus orderStatus) 
        {
           orderDao.OrderStatusUpdate(orderId, orderStatus);
        }

        public List<OrderItem> GetOrderItem(bool isABar, bool isAOpenOrders, int id)
        {
            return orderDao.GetOrderItems(isABar, isAOpenOrders, id);
        }

        public List<Order> GetOrders(bool isBar, bool isOpenOrders)
        {
            return orderDao.GetOrders(isBar, isOpenOrders);
        }
    }
}
