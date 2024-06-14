using ChapeauDAL;
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
    public partial class MyOrder : Form
    {
        private List<OrderItem> userOrder;

        public MyOrder()
        {
            InitializeComponent();
        }
        public MyOrder(List<OrderItem> userOrder)
        {
            InitializeComponent();
            this.userOrder = userOrder;
            FillUserOrder();
        }
        private void btnMyOrderClearOrder_Click(object sender, EventArgs e)
        {
            // Clear the list containing the order
            userOrder.Clear();
            // Clear the listview of all the ordered items
            lvMyOrderList.Items.Clear();
            // Reset the total price to 0.00
            lblMyOrderTotalPrice.Text = "€0.00";
        }

        private void btnMyOrderOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order
                {
                    TableID = 1,  // Set the table ID
                    EmployeeID = 2,  // Set the employee ID
                    orderStatus = OrderStatus.Open,  // Assuming Open is the status for a new order
                    OrderTime = DateTime.Now
                };

                OrderService orderService = new OrderService();
                orderService.FinishOrder(order, userOrder);

                MessageBox.Show("Order finalized successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void FillUserOrder()
        {
            lvMyOrderList.Items.Clear();

            foreach (OrderItem orderItem in userOrder)
            {
                ListViewItem listViewItem = new ListViewItem(orderItem.OrderCount.ToString());

                // Add subitems
                listViewItem.SubItems.Add(orderItem.MenuItem.ItemName);
                listViewItem.SubItems.Add(orderItem.MenuItem.Price.ToString("0.00"));

                // Ensure Notes is not null
                string notes = orderItem.Notes ?? "";  // If Notes is null, default to empty string
                listViewItem.SubItems.Add(notes);

                lvMyOrderList.Items.Add(listViewItem);
            }
        }
        private void MyOrder_Load(object sender, EventArgs e)
        {

        }
        private decimal CalculateTotalPrice()
        {
            return userOrder.Sum(item => item.TotalPrice);
        }

        private void lblMyOrderTotalPriceText_Click(object sender, EventArgs e)
        {

        }

        private void btnMyOrderReturn_Click(object sender, EventArgs e)
        {
            // close the dialogue
            this.Close();
        }

        private void MyOrder_Load_1(object sender, EventArgs e)
        {
            decimal totalPrice = CalculateTotalPrice();
            lblMyOrderTotalPrice.Text = $"€{totalPrice.ToString("0.00")}";
        }
    }
}
