using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ФормаКурьерскойБД
{
    public partial class MainMenu : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Курсач;Integrated Security=True";
        public MainMenu()
        {
           
            InitializeComponent();
           
        }
        string login; 
        string password;
        string sql;
        SqlCommand command;
        SqlDataReader reader;
        SqlConnection connection;


        private void SignIn_Click(object sender, EventArgs e)
        {
            // Создание подключения
            connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
                login = login_textbox.Text;
                password = Password.Text;
                if(login == Properties.Settings.Default.AdminLogin && password == Properties.Settings.Default.AdminPassword)
                {
                    AdminForm af = new AdminForm();
                    Visible = false;
                    af.ShowDialog();
                    Visible = true;
                }
                else
                {
                    sql = $"SELECT * FROM Clients where email = '{login}' and Password = '{password}'";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // Пользователь найден, обработка результата
                        Visible = false;
                        ClientForm cf = new ClientForm();
                        cf.ShowDialog();
                        Visible = true;

                    }
                    else
                    {
                        // Пользователь не найден, обработка результата
                        MessageBox.Show("Пользователь не найден");
                    }
                }             
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                login = login_textbox.Text;
                password = Password.Text;
                string sql = $"SELECT * FROM Clients where email = '{login}'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
              
                Visible = false;
                LoginForm LF = new LoginForm();
                LF.ShowDialog();
                Visible = true;                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }
        }
    }
}
