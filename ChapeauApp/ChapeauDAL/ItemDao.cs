using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    internal class ItemDao : BaseDao
    {
        public List<MenuItem> GetItem()
        {
            string query = "Select ItemID, Stock, MenuType, ItemName, Price, VAT, CategoryType FROM MENUITEM WHERE ItemID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List <MenuItem> items = new List<MenuItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    ItemID = (MenuItem)row["id"],
                    ItemName = row["ItemName"].ToString(),
                    Stock = (int)row["Stock"],
                    MenuType = (MenuType)row["MenuType"],
                    Price = (double)row["Price"],
                    VAT = (int)row["VAT"]
                };
                items.Add(item);
            }
            return items;
        }

        public MenuItem GetItemById(int id)
        {
            string query = "Select ItemID, Stock, MenuType, ItemName, Price, VAT, CategoryType FROM MENUITEM WHERE ItemID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            List<MenuItem> items = ReadTablesId(ExecuteSelectQuery(query, sqlParameters));
            if (items.Count > 0)
            {
                return items[0];
            }
            else
            {
                return null;
            }
        }
        private List<MenuItem> ReadTablesId(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    ItemID = (MenuItem)row["id"],
                    ItemName = row["ItemName"].ToString(),
                    Stock = (int)row["Stock"],
                    MenuType = (MenuType)row["MenuType"],
                    Price = (double)row["Price"],
                    VAT = (int)row["VAT"],
                    Category = (ItemCategory)row["CategoryType"]
                };
                items.Add(item);
            }
            return items;
        }
    }
}