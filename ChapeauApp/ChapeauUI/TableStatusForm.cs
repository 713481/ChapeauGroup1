﻿using System;
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
    public partial class TableStatusForm : Form
    {
        public TableStatusForm()
        {
            InitializeComponent();
        }

        private void buttonReturnToTableView_Click(object sender, EventArgs e)
        {
            Hide();
            TableViewForm tableViewForm = new TableViewForm();
            tableViewForm.ShowDialog();
        }
    }
}