using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                ListViewTables.Items.Clear();
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

                int orderId = GetOrderIdByTableNumber(tableNumber);

                if (orderId != -1)
                {
                    // Open OrderDetailForm with the selected table number
                    OrderDetailForm orderDetailForm = new OrderDetailForm(orderId, this);
                    if (orderDetailForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTablesFromDatabase();
                    }



                }
                else
                {
                    MessageBox.Show("No order found for the selected table.");
                }



                // Close the PaymentForm

            }
            else
            {
                MessageBox.Show("Please select a table.");
            }
        }

        private int GetOrderIdByTableNumber(int tableNumber)
        {
            int orderId = -1;
            string connectionString = ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT OrderID FROM [ORDER] WHERE TableID = (SELECT TableID FROM [TABLE] WHERE TableNumber = @TableNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TableNumber", tableNumber);
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out orderId))
                    {
                        return orderId;
                    }
                }
            }

            return orderId;
        }

        private void PaymentLogOutBtn_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }
    }
}
