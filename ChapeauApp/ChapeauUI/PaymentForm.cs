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
    public partial class PaymentForm : Form
    {
        private TableService tableService;
        public PaymentForm()
        {
            InitializeComponent();
            tableService = new TableService();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadTablesFromDatabase();
        }

        private void LoadTablesFromDatabase()
        {
            try
            {
                var tables = tableService.GetAllTable();
                foreach (var table in tables)
                {
                    ListViewItem item = new ListViewItem($"Table {table.TableNumber}");
                    item.SubItems.Add(((TableStatus)table.TableStatus).ToString());
                    ListViewTables.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading tables: " + ex.Message);
            }
        }

        private void Payment1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void SelectTableLbl_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (ListViewTables.SelectedItems.Count > 0)
            {
                // Extract the table number from the selected item text (assuming it's formatted like "Table 1")
                string selectedTableText = ListViewTables.SelectedItems[0].Text;
                int tableNumber = int.Parse(selectedTableText.Split(' ')[1]);

                // Open OrderDetailForm with the selected table number
                OrderDetailForm orderDetailForm = new OrderDetailForm(tableNumber);
                orderDetailForm.Show();

                // Close the PaymentForm
                
            }
            else
            {
                MessageBox.Show("Please select a table.");
            }
        }
    }
}
