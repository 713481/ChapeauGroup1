using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
        public void AddPayment(Bill bill)
        {
            string query = "INSERT INTO BILL (OrderID, TotalPrice, BillDate, PaymentMethod, Tip, Feedback) " +
                           "VALUES (@OrderID, @TotalPrice, @BillDate, @PaymentMethod, @Tip, @Feedback)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", bill.OrderID),
                new SqlParameter("@TotalPrice", bill.TotalPrice),
                new SqlParameter("@BillDate", bill.BillDate),
                new SqlParameter("@PaymentMethod", bill.PaymentMethod),
                new SqlParameter("@Tip", bill.Tip),
                new SqlParameter("@Feedback", bill.Feedback)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTableStatus(int tableId, string status)
        {
            string query = "UPDATE [TABLE] SET TableStatus = @Status WHERE TableID = @TableID";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableID", tableId),
                new SqlParameter("@Status", status)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public int GetOrderIDByTableID(int tableId)
        {
            string query = "SELECT OrderID FROM [ORDER] WHERE TableID = @TableID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableID", tableId)
            };
            return (int)ExecuteScalarQuery(query, sqlParameters);
        }
    }
}

