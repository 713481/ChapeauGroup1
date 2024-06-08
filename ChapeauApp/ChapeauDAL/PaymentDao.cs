using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
        private string connectionString;

        public PaymentDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method to add a new payment record to the BILL table
        public bool AddPayment(Bill bill)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO BILL (OrderId, TotalPrice, BillDate, PaymentMethod, Tip, Feedback)
                VALUES (@OrderId, @TotalPrice, @BillDate, @PaymentMethod, @Tip, @Feedback)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", bill.OrderID);
                    command.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                    command.Parameters.AddWithValue("@BillDate", bill.BillDate);
                    command.Parameters.AddWithValue("@PaymentMethod", bill.PaymentMethod);
                    command.Parameters.AddWithValue("@Tip", bill.Tip);
                    command.Parameters.AddWithValue("@Feedback", bill.Feedback);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check if the insert was successful
                    return result > 0;
                }
            }
        }

        // Method to get the total price for a given order ID
        public double GetTotalPrice(int orderId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT TotalPrice
                FROM BILL
                WHERE OrderId = @OrderId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && double.TryParse(result.ToString(), out double totalPrice))
                    {
                        return totalPrice;
                    }
                    else
                    {
                        throw new Exception("Total price not found for the specified order ID.");
                    }
                }
            }
        }

        public bool UpdatePayment(Bill bill)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                UPDATE BILL
                SET TotalPrice = @NewTotalPrice, Tip = @NewTip, Feedback = @NewFeedback
                WHERE BillID = @BillID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BillID", bill.BillID);
                    command.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                    command.Parameters.AddWithValue("@Tip", bill.Tip);
                    command.Parameters.AddWithValue("@Feedback", bill.Feedback);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check if the update was successful
                    return result > 0;
                }
            }
        }

    }
}
