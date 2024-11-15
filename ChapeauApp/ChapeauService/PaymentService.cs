﻿using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class PaymentService
    {
        private PaymentDao paymentDAO;
        private string connectionString;

        public PaymentService(string connectionString)
        {
            paymentDAO = new PaymentDao(connectionString);
            this.connectionString = connectionString;
        }

        // Method to process a payment and add it to the database
        public bool ProcessPayment(int orderId, double totalPrice, DateTime billDate, string paymentMethod, double tip, string feedback)
        {
            // Create a new Bill object
            Bill bill = new Bill
            {
                OrderID = orderId,
                TotalPrice = totalPrice,
                BillDate = billDate,
                PaymentMethod = paymentMethod,
                Tip = tip,
                Feedback = feedback
            };

            // Adds the payment record to the database
            return paymentDAO.AddPayment(bill);
        }


        
      

        // Method to get the total price for an order ID
        public double GetTotalPrice(int orderId)
        {
            return paymentDAO.GetTotalPrice(orderId);
        }

      

        public void MarkOrderAsPaid(int orderId)
        {
            string query = "UPDATE [ORDER] SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderStatus", (int)OrderStatus.Paid),
                new SqlParameter("@OrderID", orderId)
            };

            ExecuteNonQuery(query, sqlParameters);
        }

        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(sqlParameters);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ExecuteNonQuery(string query, SqlParameter[] sqlParameters)
        {
           
            string connectionString = "Server=chapeaugroup1.database.windows.net;\r\n        user id=testadmin;\r\n        password=W3lcomE123!;\r\n        Initial Catalog=chapeaugroup1;\r\n        persistsecurityinfo=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(sqlParameters);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}

