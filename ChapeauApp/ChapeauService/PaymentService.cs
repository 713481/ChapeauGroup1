using ChapeauModel;
using ChapeauDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class PaymentService
    {
        private PaymentDao paymentDao;
        private TableDao tableDao;

        public PaymentService()
        {
            paymentDao = new PaymentDao();
            tableDao = new TableDao();
        }

        public List<Table> GetAllTables()
        {
            return tableDao.GetTables();
        }

        public int GetOrderIDByTableID(int tableID)
        {
            return paymentDao.GetOrderIDByTableID(tableID);
        }

        public void ProcessPayment(int tableId, Bill bill)
        {
            bill.BillDate = DateTime.Now;
            paymentDao.AddPayment(bill);
            paymentDao.UpdateTableStatus(tableId, "free");
        }



    }
}
