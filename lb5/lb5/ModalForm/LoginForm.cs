using lb5.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb5.ModalForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Passport_n.MaxLength = 6;
            Passport_s.MaxLength = 4;
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string passwprd = Password.Text;
            string passport_n = Passport_n.Text;
            string pasport_s = Passport_s.Text;
            string fullName = FullName.Text;

            if(ClientController.AddClient(fullName, passport_n, pasport_s, login, passwprd))
            {
                MessageBox.Show("Клиент создан");
            }
            else
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
