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
    public partial class DishEditor : Form
    {
        private OrderItem orderItem;

        public DishEditor(OrderItem orderItem)
        {
            InitializeComponent();
            this.orderItem = orderItem;

            lblDECurrentDish.Text = orderItem.MenuItem.ItemName;
            lblDEOrderedCountText.Text = $"Ordered count: {orderItem.OrderCount.ToString()}";
            tbxDENotes.Text = orderItem.Notes;
        }


        private void btnDishEditorIncreaseCount_Click(object sender, EventArgs e)
        {
            orderItem.OrderCount++;
            lblDEOrderedCountText.Text = $"Ordered count: {orderItem.OrderCount.ToString()}";
        }

        private void btnDishEditorDecreaseCount_Click(object sender, EventArgs e)
        {
            if (orderItem.OrderCount > 1)
            {
                orderItem.OrderCount--;
                lblDEOrderedCountText.Text = $"Ordered count: {orderItem.OrderCount.ToString()}";
            }
        }
        private void AddNoteToTextBox(string note)
        {
            tbxDENotes.Text += note;
        }


        private void btnDEDone_Click(object sender, EventArgs e)
        {
            orderItem.Notes = tbxDENotes.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDEAllergicPeanuts_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("Allergic to Peanuts!!! ");
        }

        private void btnDEVegetarian_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("Vegetarian! ");
        }

        private void btnDESeperateSauce_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("Sauce seperated please! ");
        }

        private void btnDENoSauce_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("No sauce! ");
        }

        private void btnDERare_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("Customer prefers it cooked: Rare ");
        }

        private void btnDEMedRare_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("Customer prefers it cooked: Medium Rare ");
        }

        private void btnDEMedium_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("Customer prefers it cooked: Medium ");
        }

        private void btnDEWellDone_Click(object sender, EventArgs e)
        {
            AddNoteToTextBox("Customer prefers it cooked: Well done (burnt) ");
        }
    }
}
