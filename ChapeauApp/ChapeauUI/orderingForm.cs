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
        public orderingForm()
        {
            InitializeComponent();
            orderService = new OrderService();
            userOrder = new List<OrderItem>();
            FillMenuItems();
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
        private void FillMenuItems()
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
                lvOrderingMenuItems.Items.Add(listViewItem);
            }
        }
        private void FilterMenuItems(MenuType menuType)
        {
            // Clear existing items
            lvOrderingMenuItems.Items.Clear();

            // Retrieve menu items from the database
            List<MenuItem> menuItems = orderService.GetAllMenuItems();

            // Filter menu items based on the selected menu type
            List<MenuItem> filteredMenuItems = menuItems.Where(item => item.MenuType == menuType).ToList();

            // Add filtered items to the ListView
            foreach (MenuItem item in filteredMenuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemName);
                listViewItem.SubItems.Add(item.Price.ToString(".00")); // Format as currency
                listViewItem.SubItems.Add(item.Stock.ToString());

                lvOrderingMenuItems.Items.Add(listViewItem);
            }
        }

        private void btnOrderingMyOrder_Click(object sender, EventArgs e)
        {
            MyOrder myOrderForm = new MyOrder(userOrder);
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
                    OrderItem orderItem = new OrderItem
                    {
                        MenuItem = selectedMenuItem,
                        OrderCount = 1, // You might want to ask for a count or manage it differently
                        Notes = "", // Add any notes if necessary
                        OrderTime = DateTime.Now,
                        StatusItem = ItemStatus.Open
                    };

                    userOrder.Add(orderItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to add.");
            }
        }
    }
}
