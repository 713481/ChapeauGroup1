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
        private ItemDao itemDao;
        public OrderService() 
        { 
            orderDao = new OrderDao(); 
            itemDao = new ItemDao();
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
        public List<MenuItem> GetAllMenuItems()
        {
            return itemDao.GetAllItems();
        }
        public void FinishOrder(Order order, List<OrderItem> orderItems)
        {
            // Create the order and get the new OrderID
            int newOrderId = orderDao.CreateOrder(order);

            // Add each order item to the database
            foreach (OrderItem orderItem in orderItems)
            {
                orderItem.OrderID = newOrderId;
                orderDao.AddOrderItem(orderItem);
            }
        }
        // Ro Bben
        public void ChangeStatus(OrderItem orderItem, ItemStatus statusToChange)
        {
            orderDao.ChangeStatus(orderItem, statusToChange);
        }

        public void OrderStatusUpdate(int orderId, OrderStatus orderStatus) 
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

        public List<Order> GetHistoryOrders(OrderStatus status, bool isBar, bool isOpenOrders)
        {
            return orderDao.GetHistoryOrders(status, isBar, isOpenOrders);
        }
    }
}
