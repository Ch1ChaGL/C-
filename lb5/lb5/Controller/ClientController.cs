using SQLLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lb5.Query;
using System.Data;

namespace lb5.Controller
{
    internal class ClientController
    {
        static SQL database = new SQL();
        static public SqlDataReader getClients()
        {
            return database.ExecuteReader($"select * from Client");
        }
        static public DataTable getClientsToDataTable()
        {
            return database.ExecuteQuery("select ClientID, FullName, Passport_s, Passport_n, Login from Client").DataTable;
        }
        static public SqlDataReader getClientsByLogin (string login)
        {
            return database.ExecuteReader($"select * from Client where Login = '{login}'");
        }
        static public DataTable getClientsByLoginToDataTable(int id)
        {
            return database.ExecuteQuery($"select FullName, Passport_s, Passport_n, Login from Client where ClientID = {id}").DataTable;
        }
        static public SQL.QueryResult GetClientOrders(string login)
        {
            return database.ExecuteQuery(Query.Query.getClientOrdersQuery(login));
        }

        static public bool AddClient(string fullName, string passport_n, string passport_s, string login, string password)
        {
            try
            {
                database.ExecuteNonQuery($"insert into Client values('{fullName}', '{passport_n}', '{passport_s}', '{login}', '{password}')");
                return true;
            }catch (Exception e)
            {
                return false;
            }
            
        }
        static public int getClientIDByLogin(string login)
        {
            return database.ExecuteScalar<int>($"select ClientID where Login = '{login}'");
        }
    }
}
