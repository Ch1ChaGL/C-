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
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ФормаКурьерскойБД
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Login.Enabled = false;
        }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Курсач;Integrated Security=True";

        private void checTextBox()
        {
            bool allFilled = !string.IsNullOrEmpty(Fullname.Text) && !string.IsNullOrEmpty(PhoneNumber.Text)
            && !string.IsNullOrEmpty(Email.Text) && !string.IsNullOrEmpty(City.Text)
            && !string.IsNullOrEmpty(Street.Text) && !string.IsNullOrEmpty(House.Text) && !string.IsNullOrEmpty(Password.Text);
            Login.Enabled = allFilled;
        }
        private void Fullname_TextChanged(object sender, EventArgs e)
        {
            checTextBox();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string fullname = Fullname.Text;
            string phone = PhoneNumber.Text;
            string email = Email.Text;
            string city = City.Text;
            string street = Street.Text;
            string house = House.Text;
            string password = Password.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string sqlExpression1 = $"select * from Clients where Email = '{email}'";
                SqlCommand cmd = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Данный Email занят");
                }
                else
                {
                    reader.Close();
                    string sqlExpression2 = $"Insert into Clients values ('{fullname}','{password}', '{phone}', '{email}', '{city}', '{street}', '{house}')";
                    SqlCommand cmd2 = new SqlCommand(sqlExpression2, connection);
                    int count = cmd2.ExecuteNonQuery();
                    Console.WriteLine("Количество добавленных строк ", count);
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
