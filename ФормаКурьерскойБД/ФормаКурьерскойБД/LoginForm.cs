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
        deliveryServiceDatabase database = new deliveryServiceDatabase();       
        private void checTextBox()
        {
            bool emailValid = false; ;
            if (Email.Text.Contains('@') && Email.Text.Count(c => c == '@') == 1)
            {
                emailValid = true;// ваш код для случая, когда в строке содержится только один символ '@'
            }
            bool allFilled = !string.IsNullOrEmpty(Fullname.Text) && !string.IsNullOrEmpty(PhoneNumber.Text)
            && !string.IsNullOrEmpty(Email.Text) && !string.IsNullOrEmpty(City.Text)
            && !string.IsNullOrEmpty(Street.Text) && !string.IsNullOrEmpty(House.Text) && !string.IsNullOrEmpty(Password.Text);
            Login.Enabled = allFilled && emailValid;
            
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
            try
            {

                string sqlExpression1 = $"select * from Clients c, Manager m where m.Email = '{email}' or c.Email = '{email}'";
                SqlDataReader reader = database.ExecuteReader(sqlExpression1, CommandType.Text);
                if (reader.HasRows)
                {
                    MessageBox.Show("Данный Email занят");
                }
                else
                {
                    reader.Close();
                    string sqlExpression2 = $"Insert into Clients values ('{fullname}','{password}', '{phone}', '{email}', '{city}', '{street}', '{house}')";
                    database.ExecuteNonQuery(sqlExpression2, CommandType.Text);         
                    Close();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }
          
        

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
