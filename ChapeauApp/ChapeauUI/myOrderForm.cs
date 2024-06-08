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
    public partial class myOrderForm : Form
    {
        private List<OrderItem> userOrder;
        public myOrderForm()
        {
            InitializeComponent();
        }
        public myOrderForm(List<OrderItem> userOrder)
        {
            InitializeComponent();
            this.userOrder = userOrder;
            FillUserOrder();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderingReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void myOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
