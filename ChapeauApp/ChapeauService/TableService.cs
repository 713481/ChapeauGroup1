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
        public List<Table> GetAllTable()
        {
            return tableDao.GetTables();
        }
        public void UpdateTableStatus(int tableNumber, int tableStatus)
        {
            tableDao.UpdatesTableStatus(tableNumber, tableStatus);
        }

    }
}
