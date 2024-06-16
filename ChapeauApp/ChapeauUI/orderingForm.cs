using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class orderingForm : Form
    {
        private List<MenuItem> menuItems;
        private List<OrderItem> userOrder;
        private OrderService orderService;
        private int tableNumber;
        public orderingForm(int tableNumber)
        {
            InitializeComponent();
            // creating orderService for methods in orderService
            // creating userOrder to add menuItems into the list as order
            // calling tableNumber from table overview
            orderService = new OrderService();
            userOrder = new List<OrderItem>();
            this.tableNumber = tableNumber;

            // Add table number to label
            lblOrderingTableNumber.Text = $"Table Number: {tableNumber}";

            // Fill and Filter menu (listview)
/*            FillMenuItems();*/
            FilterMenuItems(MenuType.Lunch);
        }
        private void orderingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrderingLunch_Click(object sender, EventArgs e)
        {
            FilterMenuItems(MenuType.Lunch);
        }

        private void btnOrderingDiner_Click(object sender, EventArgs e)
        {
            FilterMenuItems(MenuType.Dinner);
        }

        private void btnOrderingDrink_Click(object sender, EventArgs e)
        {
            FilterMenuItems(MenuType.Drinks);
        }
        // Code previous to the filter to fill the list view with all dishes
/*        private void FillMenuItems()
        {
            // Clear existing items
            lvOrderingMenuItems.Items.Clear();

            // Retrieve menu items from the database
            menuItems = orderService.GetAllMenuItems();

            // Add items to the ListView
            foreach (MenuItem item in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemName.ToString());
                listViewItem.SubItems.Add(item.Price.ToString(".00"));
                listViewItem.SubItems.Add(item.Stock.ToString());
                // Set color based on stock level
                if (item.Stock == 0)
                {
                    listViewItem.ForeColor = Color.White;
                    listViewItem.BackColor = Color.Red;
                }
                else if (item.Stock <= 10)
                {
                    listViewItem.ForeColor = Color.White;
                    listViewItem.BackColor = Color.Orange;
                }
                lvOrderingMenuItems.Items.Add(listViewItem);
            }
        }*/
        // Fill the entire listview with dishes through the filter.
        private void FilterMenuItems(MenuType menuType)
        {
            // Clear existing items
            lvOrderingMenuItems.Items.Clear();

            // Retrieve menu items from the database
            menuItems = orderService.GetAllMenuItems();

            // Filter menu items based on the selected menu type
            List<MenuItem> filteredMenuItems = menuItems.Where(item => item.MenuType == menuType).ToList();

            // Add filtered items to the ListView
            foreach (MenuItem item in filteredMenuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemName);
                listViewItem.SubItems.Add(item.Price.ToString(".00")); // Format as currency
                listViewItem.SubItems.Add(item.Stock.ToString());
                // Set color based on stock level
                if (item.Stock == 0)
                {
                    listViewItem.ForeColor = Color.White;
                    listViewItem.BackColor = Color.Red;
                }
                else if (item.Stock <= 10)
                {
                    listViewItem.ForeColor = Color.White;
                    listViewItem.BackColor = Color.Orange;
                }
                lvOrderingMenuItems.Items.Add(listViewItem);
            }
        }

        private void btnOrderingMyOrder_Click(object sender, EventArgs e)
        {
            MyOrder myOrderForm = new MyOrder(tableNumber, userOrder, this);
            myOrderForm.ShowDialog();
        }

        private void btnOrderingAddDishes_Click(object sender, EventArgs e)
        {
            if (lvOrderingMenuItems.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvOrderingMenuItems.SelectedItems[0];
                MenuItem selectedMenuItem = menuItems.FirstOrDefault(item => item.ItemName == selectedItem.Text);

                if (selectedMenuItem != null)
                {
                    // Checking if the stock is 0 if true return...
                    if (selectedMenuItem.Stock == 0)
                    {
                        MessageBox.Show("This dish is out of stock, please choose something else!");
                        return; // Exit the method early
                    }

                    // Check if the item already exists in userOrder
                    OrderItem existingOrderItem = userOrder.FirstOrDefault(item => item.MenuItem.ItemID == selectedMenuItem.ItemID);

                    if (existingOrderItem != null)
                    {
                        // Increment the count if it exists
                        existingOrderItem.OrderCount++;
                    }
                    else
                    {
                        // Add a new order item if it doesn't exist
                        OrderItem orderItem = new OrderItem
                        {
                            MenuItem = selectedMenuItem,
                            OrderCount = 1, // Initially set to 1
                            Notes = "", // Add any notes if necessary
                            OrderTime = DateTime.Now,
                            StatusItem = ItemStatus.Open
                        };

                        userOrder.Add(orderItem);
                    }
                }
                else
                {
                    MessageBox.Show("Selected menu item not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to add.");
            }
        }

        private void btnOrderingReturn_Click(object sender, EventArgs e)
        {
            // Message , Title, Buttons
            DialogResult result = MessageBox.Show("Are you sure you want to stop ordering?", "Confirm Return", MessageBoxButtons.YesNo);

            // If yes is pressed close form
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            // If no is pressed return and nothing happens.
        }
    }
}
