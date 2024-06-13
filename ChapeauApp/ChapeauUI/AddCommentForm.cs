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
    public partial class AddCommentForm : Form
    {
        public string Comment { get; set; }
        public AddCommentForm()
        {
            InitializeComponent();

        }

        private void AddCommentTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCommentForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Comment = AddCommentTxtBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
