using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lb5.consts;
using SQLLib;

namespace lb5.Services
{
    internal class AllServices
    {
        static SQL database = new SQL();
        public static Consts.UserType GetUserRole(string login)
        {
            var client = database.ExecuteReader($"select * from Client where Login = '{login}'");
            var cashier = database.ExecuteReader($"select * from Cashier where Login = '{login}'");

            if (client.HasRows)
                return Consts.UserType.Client;

            return Consts.UserType.Cashier;
        }

    }
}
