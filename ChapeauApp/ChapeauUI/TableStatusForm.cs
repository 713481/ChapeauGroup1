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
using System.Timers;


namespace ChapeauUI
{
    public partial class TableStatusForm : Form
    {
        private int tableNumber;
        private TableService tableService;
        private Employee employee;
        
        public TableStatusForm(Employee employee, int tableNumber)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
            this.employee = employee;
            tableService = new TableService();
            //loading and set up timer 
           
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave this table?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                TableViewForm tableViewForm = new TableViewForm(employee);
                tableViewForm.ShowDialog();

            }

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
        // Method to retrieve and display order items details in the list view
        private void GetOrderDetails(int tableNumber)
        {
            List<OrderItem> orderItems = tableService.GetItemsOrderByTable(tableNumber);
            listViewTableStatusOrderList.Items.Clear();
            foreach (OrderItem item in orderItems)
            {
                ListViewItem li = new ListViewItem(item.ItemID.ToString());
                li.SubItems.Add(item.StatusItem.ToString());
                li.SubItems.Add(item.WaitingTime.ToString("hh\\:mm\\:ss"));
                li.Tag = item;
                listViewTableStatusOrderList.Items.Add(li);
            }
        }
        private void buttonOccupyingTables_Click(object sender, EventArgs e)
        {
            //confirmation dialog

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to occupy this table?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateTableStatus(2);

            }


        }

        private void buttonFreeingTable_Click(object sender, EventArgs e)
        {
            //confirmation dialog 
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to occupy this table?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateTableStatus(1);

            }
        }

        private void TableStatusOrderbutton_Click(object sender, EventArgs e)
        {

            this.Hide();
            orderingForm orderingForm = new orderingForm(employee, tableNumber);
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

        private void button1ChangingStatusToServed_Click(object sender, EventArgs e)
        {
            if (listViewTableStatusOrderList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTableStatusOrderList.SelectedItems[0];
                OrderItem orderItem = (OrderItem)selectedItem.Tag;

                // Confirmation dialog
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to mark this item as served?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Update the status of the selected order item to Served
                    tableService.UpdateOrderItemStatus(orderItem.ItemID, ItemStatus.Served);

                    // Refresh the list view the updated status
                    GetOrderDetails(tableNumber);
                }
            }
            else
            {
                MessageBox.Show("Please select an order item to serve.", "No item selected", MessageBoxButtons.OK);
            }

        }

        private void timerRefreshs_Tick(object sender, EventArgs e)
        {
            GetOrderDetails(tableNumber);
        }
    }
}
