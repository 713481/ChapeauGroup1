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
    public partial class SplitBillForm : Form
    {
        public int NumberOfPersons {get; private set;}
        public SplitBillForm()
        {
            InitializeComponent();

        }

        private void AmountOfPersonsTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if(int.TryParse(AmountOfPersonsTxtBox.Text, out int numberofPersons) && numberofPersons > 0)
            {
                NumberOfPersons = numberofPersons;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid number of persons.");
            }
        }
    }
}
