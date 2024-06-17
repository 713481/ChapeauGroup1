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
        private Form orderingForm;
        private List<OrderItem> userOrder;
        private int tableNumber;
        private Employee employee;

        public MyOrder()
        {
            InitializeComponent();
        }
        public MyOrder(Employee employee, int tableNumber, List<OrderItem> userOrder, Form orderingForm)
        {
            InitializeComponent();
            this.userOrder = userOrder;
            this.orderingForm = orderingForm;
            this.tableNumber = tableNumber;
            this.employee = employee;
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
                    TableID = tableNumber,  // Set the table ID
                    EmployeeID = employee.EmployeeID,  // Set the employee ID
                    orderStatus = OrderStatus.Open,  // Set the status Open for a new order
                    OrderTime = DateTime.Now // Set current time of ordering
                };

                OrderService orderService = new OrderService();
                // pass the order and the list of orderedDishes
                orderService.FinishOrder(order, userOrder);

                MessageBox.Show("Order finalized successfully!");
                this.Close();
                orderingForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void btnMyOrderEditDish_Click(object sender, EventArgs e)
        {
            if (lvMyOrderList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvMyOrderList.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                // Get the corresponding OrderItem from userOrder
                OrderItem selectedOrderItem = userOrder[selectedIndex];

                // Hide the current Form
                this.Hide();

                // Open DishEditor form to edit the selected OrderItem
                using (DishEditor editorForm = new DishEditor(selectedOrderItem, this))
                {
                    if (editorForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the ListView to reflect changes
                        FillUserOrder();
                        decimal totalPrice = CalculateTotalPrice();
                        lblMyOrderTotalPrice.Text = $"€{totalPrice.ToString("0.00")}";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }
        private void btnMyOrderRemoveDish_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListView
            if (lvMyOrderList.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lvMyOrderList.SelectedItems[0];

                // Assuming the first subitem is the OrderCount and the second is the ItemName
                string itemName = selectedItem.SubItems[1].Text;

                // Find the corresponding OrderItem in the userOrder list
                OrderItem orderItemToRemove = userOrder.FirstOrDefault(item => item.MenuItem.ItemName == itemName);

                if (orderItemToRemove != null)
                {
                    // Remove the item from the order list
                    userOrder.Remove(orderItemToRemove);

                    // Refresh the ListView
                    FillUserOrder();

                    // Update the total price label
                    decimal totalPrice = CalculateTotalPrice();
                    lblMyOrderTotalPrice.Text = $"€{totalPrice.ToString("0.00")}";
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
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

                // Calculate total price of a dish
                decimal totalPrice = orderItem.MenuItem.Price * orderItem.OrderCount;
                listViewItem.SubItems.Add(totalPrice.ToString("0.00"));  // Display total price for this item

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
            decimal totalPrice = 0;

            foreach (OrderItem orderItem in userOrder)
            {
                totalPrice += orderItem.MenuItem.Price * orderItem.OrderCount;
            }

            return totalPrice;
        }

        private void lblMyOrderTotalPriceText_Click(object sender, EventArgs e)
        {

        }

        private void btnMyOrderReturn_Click(object sender, EventArgs e)
        {
            // Show the orderingForm
            orderingForm.Show();
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
