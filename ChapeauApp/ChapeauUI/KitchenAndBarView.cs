using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenAndBarView : Form
    {
        bool isBar;
        bool isOpenOrder;
        OrderService orderService;
        public KitchenAndBarView(Employee employee)
        {
            InitializeComponent();
            if (employee.Role == StaffRole.Chef)
            {
                isBar = false;
            }
            else
            {
                isBar = true;
            }

            if (isBar)
            {
                lblViewKitchenBar.Text = "Bar View";
            }
            else
            {
                lblViewKitchenBar.Text = "Kitchen View";
            }
            isOpenOrder = true;
            orderService = new OrderService();
            OrdersDisplaying();
        }

        void OrdersDisplaying()
        {
            try
            {
                List<Order> orders = orderService.GetOrders(isBar, isOpenOrder);
                ListViewOrdersKitchen.Items.Clear();
                listViewKitchenOrderItem.Items.Clear();
                foreach (Order order in orders)
                {
                    ListViewItem li = new ListViewItem(order.OrderID.ToString());
                    li.SubItems.Add(order.TableID.ToString());
                    li.SubItems.Add(order.OrderTime.ToString("H:mm"));
                    if (isOpenOrder)
                    {
                        li.SubItems.Add($"{order.CustomerWaitingTime.TotalHours:0}:{order.CustomerWaitingTime.Minutes:00}");
                    }
                    //li.SubItems.Add(order.OrderStatus.ToString());
                    li.Tag = order;
                    ListViewOrdersKitchen.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<OrderItem> GetOrderItems(int orderID)
        {
            List<OrderItem> orderItems = orderService.GetOrderItem(isBar, isOpenOrder, orderID);
            return orderItems;
        }

        public void DisplayOrderItems(Order selectedOrder)
        {
            try
            {
                listViewKitchenOrderItem.Items.Clear();
                foreach (var item in selectedOrder.OrderList)
                {
                    ListViewItem li = new ListViewItem(item.OrderID.ToString());
                    li.SubItems.Add(item.MenuItem.ItemID.ToString());
                    li.SubItems.Add(item.OrderCount.ToString());
                    li.SubItems.Add(item.StatusItem.ToString());
                    li.SubItems.Add(item.Notes.ToString());
                    li.SubItems.Add(item.OrderTime.ToString("h:mm"));
                    li.Tag = item;
                    listViewKitchenOrderItem.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewOrdersKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewOrdersKitchen.SelectedItems.Count > 0)
            {
                try
                {
                    Order selectedOrder = (Order)ListViewOrdersKitchen.SelectedItems[0].Tag;
                    if (selectedOrder != null)
                    { 
                            DisplayOrderItems(selectedOrder);
                      
                    }
                    else
                    {
                        MessageBox.Show("Please select an order.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void butSetToReady_Click(object sender, EventArgs e)
        {
            if (listViewKitchenOrderItem.SelectedItems.Count == 0 || listViewKitchenOrderItem.SelectedItems == null)
            {
                MessageBox.Show("Select Item ID");
            }
            else
            {
                try
                {
                    OrderItem selectedItem = (OrderItem)listViewKitchenOrderItem.SelectedItems[0].Tag;

                    // Call the ChangeStatus method to update the status to Ready
                    orderService.ChangeStatus(selectedItem, ItemStatus.Ready);

                    // Optionally, you can update the UI or perform any other actions here

                    MessageBox.Show("Item status updated to Ready.");
                    listViewKitchenOrderItem.Items.Remove(listViewKitchenOrderItem.SelectedItems[0]);
                    bool allItemsReady = true;
                    foreach (ListViewItem item in listViewKitchenOrderItem.Items)
                    {
                        OrderItem orderItem = (OrderItem)item.Tag;
                        if (orderItem.StatusItem != ItemStatus.Ready)
                        {
                            allItemsReady = false;
                            break;
                        }
                    }

                    // If all items are ready, remove the order from ListViewOrdersKitchen
                    if (allItemsReady)
                    {
                        Order order = (Order)ListViewOrdersKitchen.SelectedItems[0].Tag;
                        orderService.OrderStatusUpdate(order.OrderID, OrderStatus.Served);
                        ListViewOrdersKitchen.Items.Remove(ListViewOrdersKitchen.SelectedItems[0]);
                        MessageBox.Show($"Order {order.OrderID} is served");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void butChangeStatus_Click(object sender, EventArgs e)
        {
            ChangStatusOfItem(ItemStatus.Preparing);
        }

        void ChangStatusOfItem(ItemStatus changeStatus)
        {
            try
            {
                foreach (ListViewItem li in listViewKitchenOrderItem.SelectedItems)
                {
                    OrderItem currentItem = (OrderItem)li.Tag;

                    if (changeStatus <= currentItem.StatusItem)
                    {
                        MessageBox.Show("You should choose an item with a higher or the same status.");
                        return; // Exit the method to prevent further processing
                    }

                    // Check if the difference between changeStatus and currentItem's status is greater than 1
                    if (changeStatus - currentItem.StatusItem > 1)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to break the sequence of statuses?", "Sequence of Statuses", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            return; // Exit the method if the user chooses not to break the sequence
                        }
                        break; // Break out of the loop if the user confirms breaking the sequence
                    }
                    orderService.ChangeStatus((OrderItem)li.Tag, changeStatus);
                    li.SubItems[3].Text = changeStatus.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There are some errors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butLogOutKitchen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        void HistoryOrdersDisplaying()
        {
            try
            {
                List<Order> orders = orderService.GetHistoryOrders(OrderStatus.Served, isBar, isOpenOrder);
                ListViewOrdersKitchen.Items.Clear();
                listViewKitchenOrderItem.Items.Clear();
                foreach (Order order in orders)
                {
                    ListViewItem li = new ListViewItem(order.OrderID.ToString());
                    li.SubItems.Add(order.TableID.ToString());
                    li.SubItems.Add(order.OrderTime.ToString("H:mm"));
                    if (isOpenOrder)
                    {
                        li.SubItems.Add($"{order.CustomerWaitingTime.TotalHours:0}:{order.CustomerWaitingTime.Minutes:00}");
                    }
                    //li.SubItems.Add(order.OrderStatus.ToString());
                    li.Tag = order;
                    ListViewOrdersKitchen.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryButton.Text = isOpenOrder ? "Show Orders" : "Show History";
            lblViewKitchenBar.Text = isOpenOrder ? "History" : "Open Orders";
            butSetToReady.Enabled = isOpenOrder;
            butChangeStatus.Enabled = isOpenOrder;
            isOpenOrder = !isOpenOrder;
            HistoryOrdersDisplaying();
        }
    }
}
