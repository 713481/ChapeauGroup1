using ChapeauDAL;
using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private int orderId;
        private PaymentService paymentService;
        private int tableNumber;
        private PaymentOrderService paymentOrderService;
        private OrderDao orderDao;
        private bool hasShownMessage = false;
        private PaymentForm PaymentForm;
        

        public OrderDetailForm(int orderId, PaymentForm paymentForm)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString;
            this.orderId = orderId;
            this.tableNumber = GetTableNumberByOrderId(orderId);
            this.paymentOrderService = new PaymentOrderService();
            this.paymentService = new PaymentService(connectionString);
            this.orderDao = new OrderDao();
            this.PaymentForm = new PaymentForm();
            this.PaymentForm = paymentForm;
            





        }


        private void LoadOrderDetails()
        {
            try
            {
                ShowTableNbLbl.Text = $"Table {tableNumber}";
                var orderDetails = paymentOrderService.GetOrderDetailsByTableNumber(tableNumber); // Fetch order details

                if (orderDetails == null || !orderDetails.Any() || !orderDetails.Any(detail => detail.orderStatus != OrderStatus.Paid))
                {
                    if (!hasShownMessage)
                    {
                        MessageBox.Show("There are no unpaid orders for this table.");
                        hasShownMessage = true; // Set the flag
                    }


                    OrderDetailsListView.Items.Clear();
                    FinalPriceLbl.Text = "0,00 €";
                    return;
                }

                orderDetails = orderDetails.Where(detail => detail.orderStatus != OrderStatus.Paid).ToList();



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
                    listViewItem.SubItems.Add(totalItemPrice.ToString("C", cultureInfo)); 
                    listViewItem.SubItems.Add((detail.VAT * 100).ToString("F2") + "%"); 
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

            if (decimal.TryParse(AddTipTxtBox.Text,NumberStyles.Currency,cultureInfo, out decimal tip))
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

        private int GetTableNumberByOrderId(int orderId)
        {
            int tableNumber = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT TableID FROM [Order] WHERE OrderID = @OrderID", connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    tableNumber = (int)command.ExecuteScalar();
                }
            }
            return tableNumber;
        }

        private void SplitBillBtn_Click(object sender, EventArgs e)
        {
            using (SplitBillForm splitBillForm = new SplitBillForm())
            {
                if (splitBillForm.ShowDialog() == DialogResult.OK)
                {
                    int numberOfPersons = splitBillForm.NumberOfPersons;
                    decimal totalprice = CalculateTotalPriceWithoutTip();

                    var cultureInfo = new CultureInfo("fr-FR");



                    if (decimal.TryParse(AddTipTxtBox.Text, out decimal tip))
                    {
                        totalprice += tip;
                    }

                    decimal splitPrice = totalprice / numberOfPersons;

                    SplittedPriceLbl.Text = splitPrice.ToString("c", cultureInfo);
                }
            }
        }

        private void PayCashBtn_Click(object sender, EventArgs e)
        {
            if (!OrderDetailsListView.Items.Cast<ListViewItem>().Any())
            {
                MessageBox.Show("There are no orders to pay for.");
                return;
            }
            OpenCommentForm("Cash");
            SetOrderStatusToPaid(orderId);
            LoadOrderDetails();

        }

        private void OpenCommentForm(string paymentMethod)
        {
            using (AddCommentForm addCommentForm = new AddCommentForm())
            {
                if (addCommentForm.ShowDialog() == DialogResult.OK)
                {
                    string comment = addCommentForm.Comment;
                    ProcessPayment(paymentMethod, comment);
                }
            }
        }

        private void ProcessPayment(string paymentMethod, string comment)
        {
            var cultureInfo = new CultureInfo("fr-FR");
            decimal totalprice = CalculateTotalPriceWithoutTip();
            decimal tip = 0;

            if (decimal.TryParse(AddTipTxtBox.Text, out tip))
            {
                totalprice += tip;
            }

            if (tableNumber == 0)
            {
                throw new Exception("Table ID not found for the specified order ID.");
            }

            bool paymentResult = paymentService.ProcessPayment(orderId, (double)totalprice, DateTime.Now, paymentMethod, (double)tip, comment);

            if (paymentResult)
            {
                SetOrderStatusToPaid(tableNumber);
                UpdateTableStatusToFree(tableNumber);
                ClearOrder();
                MessageBox.Show("Bill was generated and added to the database. Payment completed successfully!", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                LoadOrderDetails();

            }
            else
            {
                MessageBox.Show("An error occurred while processing the payment. Please try again.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void MarkOrderAsPaid()
        {
            try
            {
                paymentService.MarkOrderAsPaid(orderId);
                LoadOrderDetails();
                MessageBox.Show("Order has been marked as paid.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while marking the order as paid: " + ex.Message);
            }
        }

        private void SetOrderStatusToPaid(int tableId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE [ORDER] SET OrderStatus = @OrderStatus WHERE TableID = @TableID AND OrderStatus != @PaidStatus";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderStatus", 5);
                    command.Parameters.AddWithValue("@TableID", tableId);
                    command.Parameters.AddWithValue("@PaidStatus", 5);


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Order status updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were updated. Check if the OrderID is correct.");
                    }
                }
            }
        }



        private void UpdateTableStatusToFree(int tableId)
        {

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand updateTableCommand = new SqlCommand("UPDATE [TABLE] SET TableStatus = 1 WHERE TableNumber = @TableNumber", connection))
                {
                    updateTableCommand.Parameters.AddWithValue("@TableNumber    ", tableNumber);
                    updateTableCommand.ExecuteNonQuery();
                }

            }
        }

        private void ClearOrder()
        {
            OrderDetailsListView.Items.Clear();
            FinalPriceLbl.Text = "0,00 €";
            AddTipTxtBox.Text = string.Empty;
        }





        private void PayPinBtn_Click(object sender, EventArgs e)
        {
            if (!OrderDetailsListView.Items.Cast<ListViewItem>().Any())
            {
                MessageBox.Show("There are no orders to pay for.");
                return;
            }
            OpenCommentForm("Debit");
            SetOrderStatusToPaid(orderId);
            LoadOrderDetails();

        }

        private void LogOutOrderDetailBtn_Click(object sender, EventArgs e)
        {
            if (PaymentForm != null)
            {
                PaymentForm.Close();
            }

            
            this.Close();

        }
    }
}
