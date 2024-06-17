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
    public partial class TableViewForm : Form
    {
        public TableService TableService;
        private Employee employee;
        public TableViewForm(Employee employee)
        {
            InitializeComponent();
            TableService = new TableService();
            this.employee = employee;
            GetTableControl();
        }
        // Method to get and display table controls
        private void GetTableControl()
        {
            //when loading, it clear the table first
            TableViewsLayoutPanel.Controls.Clear();
            //Get table data form dtabase
            List<Table> tables = TableService.GetAllTable();
            int columnCount = 2;
            int rowIndex = 0;
            int colIndex = 0;

            foreach (Table table in tables)
            {
                UserControlTableView userControlTable = new UserControlTableView(employee, table);
                //each table number wil be assign to the label in the User Control 
                userControlTable.AssignTableNumber = table.TableNumber.ToString();

                //setting color of user control to red or green base on table status from the database
                if (table.TableStatus == 1)
                {
                    userControlTable.BackColor = Color.Green;
                }
                else if (table.TableStatus == 2)
                {
                    userControlTable.BackColor = Color.Red;
                }

                TableViewsLayoutPanel.Controls.Add(userControlTable, colIndex, rowIndex);
                colIndex++;
                if (colIndex >= columnCount)
                {
                    colIndex = 0;
                    rowIndex++;
                }


            }
        }
        private void buttonLoggingOut_Click(object sender, EventArgs e)
        {
            //confirmation dialog

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

            }        
           
        }
        private void TableViewsLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
