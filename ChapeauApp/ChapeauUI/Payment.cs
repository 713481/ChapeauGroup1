using ChapeauUI;
using ChapeauService;
using ChapeauDAL;
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

    public partial class Payment : Form
    {
        private PaymentService paymentService;

        public Payment()
        {
            InitializeComponent();
            paymentService = new PaymentService();
            LoadTables();
        }

        private void LoadTables()
        {
            try
            {
                List<Table> tables = paymentService.GetAllTables();
                TablesList.View = View.List;

                foreach (Table table in tables)
                {
                    ListViewItem item = new ListViewItem($"Table {table.TableID}");
                    TablesList.Items.Add(item);
                }

                TablesList.FullRowSelect = true;
                TablesList.MultiSelect = false;
                TablesList.HideSelection = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading tables: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TablesList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = TablesList.SelectedItems[0];
                int selectedTableId = int.Parse(selectedItem.Text.Split(' ')[1]); // Extract the table ID
                                                                                  // Handle table selection, e.g., store selectedTableId for further use
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            OrderDetailsPayment orderDetailsForm = new OrderDetailsPayment();
            orderDetailsForm.ShowDialog();
        }
    }
}
