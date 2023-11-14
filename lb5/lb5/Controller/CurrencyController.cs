using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLLib;
namespace lb5.Controller
{
    internal class CurrencyController
    {
        static SQL database = new SQL();
        static public SQL.QueryResult GetCurrency()
        {
            return database.ExecuteQuery("select * from Currency");
        }
        static public void LoadCurrencyToComboBox(ComboBox cb)
        {
            database.LoadDataToComboBox("select * from Currency", "CurrencyID", "CurrencyName", cb);
        }
        static public double GetPurchaseRate(string name)
        {
            return double.Parse(database.ExecuteScalar<decimal>($"select PurchaseRate from Currency where CurrencyName = '{name}'").ToString());
        }
        static public double GetSellingRate(string name)
        {
            return double.Parse(database.ExecuteScalar<decimal>($"select SellingRate from Currency where CurrencyName = '{name}'").ToString());
        }
        static public int getCurrencyIdByName(string name)
        {
            return database.ExecuteScalar<int>($"select CurrencyID from Currency where CurrencyName = '{name}'");
        }
    }
}
