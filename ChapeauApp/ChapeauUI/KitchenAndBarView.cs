using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class KitchenAndBarView : Form
    {


        public KitchenAndBarView()
        {
            InitializeComponent();
            OrderShowing();
        }

        bool bar;
        bool openOrder;
        OrderService orderService;

        void OrderShowing()
        {
            try
            {
                List<Order> listOfOrder = orderService.GetOrder(bar, openOrder);
                ListViewOpenOrderBar.Clear();
                listViewOrderItemBar.Clear();
                foreach (Order order in listOfOrder)
                {
                    ListViewItem li = new ListViewItem($"{order.TableID}");
                    li.SubItems.Add(order.OrderID.ToString());
                    li.SubItems.Add(order.OrderTime.ToString("H:mm"));
                    if (openOrder)
                    {
                        li.SubItems.Add($"{order.CustomerWaitingTime.TotalHours:0}:{order.CustomerWaitingTime.Minutes:00}");
                    }
                    li.Tag = order;
                    ListViewOpenOrderBar.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There are something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK);
            }


        }
     


    }
}
