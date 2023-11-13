using SQLLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5.Controller
{
    internal class LogStorageController
    {
        static SQL database = new SQL();
        public static void addLog(string login, DateTime dateTime, bool isLogin)
        {
            database.ExecuteNonQuery($"insert into logStorage values ('{dateTime}', '{login}', {(isLogin == true ? 1 : 0)})");
        }
    }
}
