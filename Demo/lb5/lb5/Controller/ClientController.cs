using SQLLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5.Controller
{
    internal class ClientController
    {
        static SQL database = new SQL();
        static public SqlDataReader getClients()
        {
            return database.ExecuteReader($"select * from Client");
        }
        static public SqlDataReader getClientsByLogin (string login)
        {
            return database.ExecuteReader($"select * from Client where Login = '{login}'");
        }
    }
}
