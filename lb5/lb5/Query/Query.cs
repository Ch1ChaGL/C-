using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5.Query
{
    internal class Query
    {
        static public string getClientOrdersQuery(string login)
        {
            return $"SELECT o.Date, c.FullName, ca.FullName as [Кассир], oc.Rate, oc.SumСurrency as [Количество валюты],oc.type, cu.CurrencyName\r\nFROM [Order] AS o\r\nJOIN Client AS c ON o.ClientID = c.ClientID\r\nJOIN Cashier AS ca ON o.CashierID = ca.CashierID\r\nJOIN OrderCurrency AS oc ON o.OrderID = oc.OrderID\r\nJOIN Currency as cu on oc.СurrencyID = cu.CurrencyID\r\nWHERE c.Login = '{login}';";
        }
    }
}
