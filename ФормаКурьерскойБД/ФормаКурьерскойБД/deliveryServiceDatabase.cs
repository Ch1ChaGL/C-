using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФормаКурьерскойБД
{
    internal class deliveryServiceDatabase
    {

        public deliveryServiceDatabase()
        {

        }
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Курсач;Integrated Security=True";
        public T ExecuteScalar<T>(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return (T)command.ExecuteScalar();
                }
            }
        }
        public  void ExecuteNonQuery(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public  SqlDataReader ExecuteReader(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            var connection = new SqlConnection(connectionString);
            using (var command = new SqlCommand(query, connection))
            {
                command.CommandType = commandType;
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public  DataTable ExecuteQuery(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        public DataTable TransposeDataTable(DataTable dt)
        {
            DataTable transposedDt = new DataTable();
            transposedDt.Columns.Add("Property", typeof(string));

            foreach (DataColumn dc in dt.Columns)
            {
                if (dc.ColumnName != "Property")
                {
                    DataRow newRow = transposedDt.NewRow();
                    newRow["Property"] = dc.ColumnName;
                    transposedDt.Rows.Add(newRow);

                    foreach (DataRow dr in dt.Rows)
                    {
                        newRow = transposedDt.NewRow();
                        newRow["Property"] = dr[dc.ColumnName];
                        transposedDt.Rows.Add(newRow);
                    }
                }
            }

            return transposedDt;
        }




    }
}
