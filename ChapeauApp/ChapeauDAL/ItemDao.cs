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
            string query = "Select ItemID, Stock, MealsType, ItemName, Price, VAT, CategoryType FROM MENUITEM WHERE ItemID = @id";
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
                    ItemID = (int)row["id"],
                    ItemName = row["ItemName"].ToString(),
                    Stock = (int)row["Stock"],
                    MenuType = (MenuType)row["MenuType"],
                    Price = (decimal)row["Price"],
                    VAT = (decimal)row["VAT"]
                };
                items.Add(item);
            }
            return items;
        }

        public MenuItem GetItemById(int id)
        {
            string query = "Select ItemID, Stock, MealsType, ItemName, Price, VAT, CategoryType FROM MENUITEM WHERE ItemID = @id";
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
                    ItemID = (int)row["ItemID"],
                    ItemName = row["ItemName"].ToString(),
                    Stock = (int)row["Stock"],
                    MenuType = (MenuType)row["MealsType"],
                    Price = (decimal)row["Price"],
                    VAT = (decimal)row["VAT"],
                    Category = (ItemCategory)row["CategoryType"]
                };
                items.Add(item);
            }
            return items;
        }
    }
}