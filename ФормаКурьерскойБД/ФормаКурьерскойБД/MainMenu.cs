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
        
        public MainMenu()
        {
           
            InitializeComponent();
           
        }
        string login; 
        string password;
        string sql;
        deliveryServiceDatabase database = new deliveryServiceDatabase();
        SqlDataReader reader;

        private void SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                login = login_textbox.Text;
                password = Password.Text;
                sql = $"SELECT idManager, idDepartment FROM Manager where email = '{login}' and Password = '{password}'";
                reader = database.ExecuteReader(sql, CommandType.Text);
                if (reader.HasRows)
                {
                    reader.Read();
                    int idManager = (int)reader.GetValue(0);
                    int idDepartment = (int)reader.GetValue(1);
                    ManagerForm Mf = new ManagerForm(idManager, idDepartment);
                    Visible = false;
                    Mf.ShowDialog();
                    Visible = true;
                }
                else
                {
                    sql = $"SELECT idClient FROM Clients where email = '{login}' and Password = '{password}'";
                    reader = database.ExecuteReader(sql, CommandType.Text);
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int id = (int)reader.GetValue(0);
                        // Пользователь найден, обработка результата
                        Visible = false;
                        ClientForm cf = new ClientForm(id);
                        cf.ShowDialog();
                        Visible = true;

                    }
                    else
                    {
                        // Пользователь не найден, обработка результата
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
                       
        }
     

        private void LogIn_Click(object sender, EventArgs e)
        {
            Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Visible = true;
        }
     



    }
}
