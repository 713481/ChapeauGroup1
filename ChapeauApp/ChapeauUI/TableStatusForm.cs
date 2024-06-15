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
using ChapeauModel;


namespace ChapeauUI
{
    public partial class TableStatusForm : Form
    {
        private int tableNumber;
        private TableService tableService;
        private OrderService orderService;

        public TableStatusForm(int tableNumber)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
            tableService = new TableService();
            orderService = new OrderService();
            GetTableNumber(tableNumber);
            GetOrderDetails(tableNumber);

        }
        // to retrieve and display table number
        public void GetTableNumber(int tableNumber)
        {
            //load the table number from the user control
            Table table = tableService.GetTableNumbers(tableNumber);
            if (table != null)
            {
                labelTableShowNumbers.Text = tableNumber.ToString();
                tableNumber = table.TableNumber;
            }
            else
            {
                MessageBox.Show("Table unable to be found.", "Error", MessageBoxButtons.OK);
            }
        }
     
        private void buttonReturnToTableView_Click(object sender, EventArgs e)
        {
            this.Close();
            Hide();
            TableViewForm tableViewForm = new TableViewForm();
            tableViewForm.ShowDialog();
        }
        // Method to update the status of the table
        private void UpdateTableStatus(int updatedStatus)
        {
            Table updatedTable = tableService.UpdateTableStatus(tableNumber, updatedStatus);
            if (updatedStatus != null)
            {
                MessageBox.Show("Table Status has updated successfully.", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failed to update Table Status.", "Failed", MessageBoxButtons.OK);
            }
        }
        // Method to retrieve and display order details in the list view
        private void GetOrderDetails(int tableNumber)
        {
            List<Order> orders = orderService.GetOrdersByTable(tableNumber);
            listViewTableStatusOrderList.Items.Clear();
            foreach (Order order in orders)
            {
              
            }
        }
        private void buttonOccupyingTables_Click(object sender, EventArgs e)
        {

            UpdateTableStatus(2);
        }

        private void buttonFreeingTable_Click(object sender, EventArgs e)
        {
            UpdateTableStatus(1);
        }

        private void TableStatusOrderbutton_Click(object sender, EventArgs e)
        {

            this.Hide();
            orderingForm orderingForm = new orderingForm();
            orderingForm.ShowDialog();
            this.Close();
        }

        private void TableStatusPaymentButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
            this.Close();
        }
    }
}
