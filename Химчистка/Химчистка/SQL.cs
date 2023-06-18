using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Химчистка
{
    internal class SQL
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Химчистка;Integrated Security=True";
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
        public void ExecuteNonQuery(string query, CommandType commandType, params SqlParameter[] parameters)
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

        public SqlDataReader ExecuteReader(string query, CommandType commandType, params SqlParameter[] parameters)
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

        public DataTable ExecuteQuery(string query, CommandType commandType, params SqlParameter[] parameters)
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

        public void LoadDataToComboBox(string query, string keyColumn, string valueColumn, ComboBox comboBox)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<KeyValuePair<string, string>> dataList = new List<KeyValuePair<string, string>>();

                    while (reader.Read())
                    {
                        string key = reader[keyColumn].ToString();
                        string value = reader[valueColumn].ToString();
                        dataList.Add(new KeyValuePair<string, string>(key, value));
                    }

                    reader.Close();

                    comboBox.DataSource = dataList;
                    comboBox.DisplayMember = "Value";
                    comboBox.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
            }
        }
        public void LoadDataToListBox(string query, string keyColumn, string valueColumn, ListBox listBox)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<KeyValuePair<string, string>> dataList = new List<KeyValuePair<string, string>>();

                    while (reader.Read())
                    {
                        string key = reader[keyColumn].ToString();
                        string value = reader[valueColumn].ToString();
                        dataList.Add(new KeyValuePair<string, string>(key, value));
                    }

                    reader.Close();

                    listBox.DataSource = dataList;
                    listBox.DisplayMember = "Value";
                    listBox.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
            }
        }
        public void LoadDataToCheckedListBox(string query, string keyColumn, string valueColumn, CheckedListBox checkedListBox)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<KeyValuePair<string, string>> dataList = new List<KeyValuePair<string, string>>();

                    while (reader.Read())
                    {
                        string key = reader[keyColumn].ToString();
                        string value = reader[valueColumn].ToString();
                        dataList.Add(new KeyValuePair<string, string>(key, value));
                    }

                    reader.Close();

                    checkedListBox.DataSource = dataList;
                    checkedListBox.DisplayMember = "Value";
                    checkedListBox.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
            }
        }
    }
}
