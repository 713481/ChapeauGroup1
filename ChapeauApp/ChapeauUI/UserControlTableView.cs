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
    public partial class UserControlTableView : UserControl
    {
        //defining an event for clicking 
        public event EventHandler ClickTable;
        //Defining the Table property
        public Table Table;
        public string AssignTableNumber
        {
            get
            {
                return labelNumberOfTable.Text;
            }
            set
            {
                labelNumberOfTable.Text = value;
            }
        }
        public UserControlTableView(Table table)
        {
            Table = table;
            InitializeComponent();
        }

        private void labelNumberOfTable_Click(object sender, EventArgs e)
        {
            // get table property of the current instance of the UserControl
            int tableNumber = Table.TableNumber;

            //making a new instance of the table status form of the table object
        }
    }
}
