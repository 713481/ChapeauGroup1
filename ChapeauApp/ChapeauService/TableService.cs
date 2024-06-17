using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class TableService
    {
        TableDao tableDao;
        public TableService()
        {
            tableDao = new TableDao();
        }
        //Get a list of all tables
        public List<Table> GetAllTable()
        {
            return tableDao.GetTables();
        }
        //Method to get a specific table
        public Table GetTableNumbers(int tablenumber)
        {
            return tableDao.GetTableNUmbers(tablenumber);
        }
        //Method to update the status of a table and return updated table 
        public Table UpdateTableStatus(int tableNumber, int tableStatus)
        {
            tableDao.UpdatesTableStatus(tableNumber, tableStatus);
            Table updatedTable = tableDao.GetTableNUmbers(tableNumber);
            return updatedTable;
        }
        //method to get order items by table
        public List<OrderItem> GetItemsOrderByTable(int tableNumber)
        {
            return tableDao.GetItemsOrderByTable(tableNumber);
        }
        //method to update the ordered item status 
        public void UpdateOrderItemStatus(int itemID, ItemStatus status)
        {
            tableDao.UpdateOrderItemStatus(itemID, status);
        }
    }
}
