using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class OrderDetailForm : Form
    {
        private int tableNumber;
        private PaymentOrderService paymentOrderService;

        public OrderDetailForm(int tableNumber)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
            this.paymentOrderService = new PaymentOrderService();
            LoadOrderDetails();


        }

        private void LoadOrderDetails()
        {
            try
            {
                ShowTableNbLbl.Text = $"Table {tableNumber}";
                var orderDetails = paymentOrderService.GetOrderDetailsByTableNumber(tableNumber); // Fetch order details

                var groupedOrderDetails = orderDetails.GroupBy(detail => new { detail.ItemName, detail.Price, detail.VAT }).Select(group => new
                {
                    ItemName = group.Key.ItemName,
                    TotalCount = group.Sum(detail => detail.OrderCount),
                    Price = group.Key.Price,
                    VAT = group.Key.VAT
                }).ToList();

                OrderDetailsListView.Items.Clear();

                decimal totalprice = 0;
                var cultureInfo = new CultureInfo("fr-Fr");
                foreach (var detail in groupedOrderDetails)
                {
                    var listViewItem = new ListViewItem($"{detail.ItemName} x{detail.TotalCount}");
                    decimal totalItemPrice = detail.Price * detail.TotalCount;
                    listViewItem.SubItems.Add(totalItemPrice.ToString("C", cultureInfo)); // Corrected Price display
                    listViewItem.SubItems.Add((detail.VAT * 100).ToString("F2") + "%"); // Corrected VAT display
                    OrderDetailsListView.Items.Add(listViewItem);

                    totalprice += totalItemPrice;
                }
                FinalPriceLbl.Text = totalprice.ToString("C", cultureInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading order details: " + ex.Message);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void AddTipTxtBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFinalPriceWithTip();
        }

        private void UpdateFinalPriceWithTip()
        {
            var cultureInfo = new CultureInfo("fr-FR");
            decimal totalPrice = CalculateTotalPriceWithoutTip();

            if (decimal.TryParse(AddTipTxtBox.Text, out decimal tip))
            {
                totalPrice += tip;
            }

            FinalPriceLbl.Text = totalPrice.ToString("C", cultureInfo);
        }

        private decimal CalculateTotalPriceWithoutTip()
        {
            decimal totalprice = 0;
            var cultureInfo = new CultureInfo("fr-FR");

            foreach (ListViewItem item in OrderDetailsListView.Items)
            {
                if (decimal.TryParse(item.SubItems[1].Text, NumberStyles.Currency, cultureInfo, out decimal itemPrice))
                {
                    var itemCountText = item.Text.Split('x')[1].Trim();
                    if (int.TryParse(itemCountText, out int itemCount))
                    {
                        totalprice += itemPrice;
                    }
                }
            }

            return totalprice;
        }

        private void SplitBillBtn_Click(object sender, EventArgs e)
        {
            using (SplitBillForm splitBillForm = new SplitBillForm())
            {
                if(splitBillForm.ShowDialog() == DialogResult.OK)
                {
                    int numberOfPersons = splitBillForm.NumberOfPersons;
                    decimal totalprice = CalculateTotalPriceWithoutTip();

                    var cultureInfo = new CultureInfo("fr-FR");

                  

                    if(decimal.TryParse(AddTipTxtBox.Text,out decimal tip))
                    {
                        totalprice += tip;
                    }

                    decimal splitPrice = totalprice / numberOfPersons;

                    SplittedPriceLbl.Text = splitPrice.ToString("c", cultureInfo);
                }
            }
        }
    }
}
