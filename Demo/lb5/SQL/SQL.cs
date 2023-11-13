using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLLib
{
    public class SQL
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Exchanger; Integrated Security=True";

        public T ExecuteScalar<T>(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return (T)command.ExecuteScalar();
                }
            }
        }


        public void ExecuteNonQuery(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            var connection = new SqlConnection(connectionString);
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public class QueryResult
        {
            public DataTable DataTable { get; set; }
            public SqlDataAdapter SqlDataAdapter { get; set; }
            public SqlCommand Command { get; set; }
        }
        /// <summary>
        /// Запрос в базу данных для вывода в таблицу
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public QueryResult ExecuteQuery(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {

                using (var command = new SqlCommand(query, connection))
                {

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return new QueryResult
                        {
                            DataTable = dataTable,
                            SqlDataAdapter = adapter,
                            Command = command
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Обновление данных в БД
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="dataTable"></param>
        /// 
        public void UpdateData(SqlDataAdapter adapter, DataTable dataTable, SqlCommand command)
        {
            using (var builder = new SqlCommandBuilder(adapter))
            {
                // Устанавливаем команду выборки
                command.Connection = getConnection();
                adapter.SelectCommand = command;
                adapter.Update(dataTable);
            }
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

        public SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
