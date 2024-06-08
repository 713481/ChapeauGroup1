using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class PaymentService
    {
        private PaymentDao paymentDAO;

        public PaymentService(string connectionString)
        {
            paymentDAO = new PaymentDao(connectionString);
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

            // Add the payment record to the database
            return paymentDAO.AddPayment(bill);
        }

        // Method to update an existing payment
        public bool UpdatePayment(int billId, double newTotalPrice, double newTip, string newFeedback)
        {
            // Fetch the existing bill
            Bill bill = new Bill
            {
                BillID = billId,
                TotalPrice = newTotalPrice,
                Tip = newTip,
                Feedback = newFeedback
            };

            // Update the payment record in the database
            return paymentDAO.UpdatePayment(bill);
        }

        // Method to get the total price for a given order ID
        public double GetTotalPrice(int orderId)
        {
            return paymentDAO.GetTotalPrice(orderId);
        }
    }

}

