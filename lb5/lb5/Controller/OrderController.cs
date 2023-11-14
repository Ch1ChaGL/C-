using SQLLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb5.Controller
{
    internal class OrderController
    {
        static SQL database = new SQL();
        public static bool createOrder(string clientCurrency, string targetCurrency, int ClientID, double countClientCurrency, string cashierLogin)
        {

            try
            {
                double clientCurrncyCount = countClientCurrency;

                double ClientPurchaseRate = CurrencyController.GetPurchaseRate(clientCurrency);
                double ClientSellingRate = CurrencyController.GetSellingRate(clientCurrency);

                double TargetPurchaseRate = CurrencyController.GetPurchaseRate(targetCurrency);


                var CashierID = CashierController.getCashierIDByLogin(cashierLogin);
                if (clientCurrency == "RUB")
                {
                    var count = Math.Round((clientCurrncyCount / TargetPurchaseRate), 2);

                    

                    var OrderID = database.ExecuteScalar<Int32>($"insert into [Order] values ({ClientID}, {CashierID}, '{DateTime.Now}'); SELECT CAST(SCOPE_IDENTITY() AS INT);");
                    var CurrencyID = CurrencyController.getCurrencyIdByName(targetCurrency);
                    var type = "ПОКУПКА";
                    var rate = CurrencyController.GetPurchaseRate(targetCurrency);

                    database.ExecuteNonQuery($"insert into OrderCurrency (OrderID, СurrencyID, SumСurrency, type, Rate) values ({OrderID}, {CurrencyID}, {count.ToString().Replace(',','.')}, '{type}', {rate.ToString().Replace(',', '.')}); ");
                    return true;
                }
                if (clientCurrency != "RUB")
                {
                    var rub = clientCurrncyCount * ClientSellingRate;
                    var count = Math.Round(rub / TargetPurchaseRate, 2);

                    var OrderID = database.ExecuteScalar<Int32>($"insert into [Order] values ({ClientID}, {CashierID}, '{DateTime.Now}'); SELECT CAST(SCOPE_IDENTITY() AS INT);");
                    var CurrencyID = CurrencyController.getCurrencyIdByName(clientCurrency);
                    var CurrencyID2 = CurrencyController.getCurrencyIdByName(targetCurrency);
                    var type1 = "ПРОДАЖА";
                    var type2 = "ПОКУПКА";
                    var rate1 = CurrencyController.GetSellingRate(clientCurrency);
                    var rate2 = CurrencyController.GetPurchaseRate(targetCurrency);
                    database.ExecuteNonQuery($"insert into OrderCurrency (OrderID, СurrencyID, SumСurrency, type, Rate) values ({OrderID}, {CurrencyID}, {countClientCurrency.ToString().Replace(',', '.')}, '{type1}', {rate1.ToString().Replace(',', '.')}); ");
                    database.ExecuteNonQuery($"insert into OrderCurrency (OrderID, СurrencyID, SumСurrency, type, Rate) values ({OrderID}, {CurrencyID2}, {count.ToString().Replace(',', '.')}, '{type2}', {rate2.ToString().Replace(',', '.')});");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
