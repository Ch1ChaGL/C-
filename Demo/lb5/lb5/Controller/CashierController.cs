using SQLLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5.Controller
{
    internal class CashierController
    {
        static SQL database = new SQL();
        static public SqlDataReader getCashier()
        {
            return database.ExecuteReader("select * from Cashier");
        }

        static public SqlDataReader getCashierByLogin(string login)
        {
            return database.ExecuteReader($"select * from Cashier where Login = '{login}' ");
        }
    }
}
