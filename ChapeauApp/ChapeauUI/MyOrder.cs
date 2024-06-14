using ChapeauModel;
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

        }
        private void FillUserOrder()
        {
            lvMyOrderList.Items.Clear();

            foreach (OrderItem orderItem in userOrder)
            {
                ListViewItem listViewItem = new ListViewItem(orderItem.OrderCount.ToString());
                listViewItem.SubItems.Add(orderItem.MenuItem.ItemName);
                listViewItem.SubItems.Add(orderItem.MenuItem.Price.ToString("0.00"));
                listViewItem.SubItems.Add(orderItem.Notes);
                lvMyOrderList.Items.Add(listViewItem);
            }
        }
        private void MyOrder_Load(object sender, EventArgs e)
        {
            decimal totalPrice = CalculateTotalPrice();
            lblMyOrderTotalPrice.Text = $"€{totalPrice.ToString("0.00")}";
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
    }
}
