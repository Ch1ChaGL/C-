using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._10
{
    public partial class Form1 : Form
    {
        Boolean flag = true;
        class User
        {

            private string name;
            private string password;
            public User(string name, string password)
            {
                this.name = name;
                this.password = password;
            }
            public User()
            {
                this.name = "";
                this.password = "";
            }
            public string Name { get { return name; } set { name = value; } }
            public string Password { get { return password; } set { password = value; } }
        }
        User user1 = new User("Данил", "1234");
        User user2 = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (flag) {
                label3.Text = "";

                string name = textBox1.Text;
                string password = textBox2.Text;
                if (name == "" && password == "")
                {
                    MessageBox.Show("Введите логин и пароль");
                    return;
                }
                else if (name == "")
                {
                    MessageBox.Show("Введите логин");
                }
                else if (password == "")
                {
                    MessageBox.Show("Введите пароль");
                }
                else
                {
                    user2 = new User(name, password);
                }
                if (user1.Name == user2.Name && user1.Password == user2.Password)
                {
                    label3.Text = "Вы успешно вошли";
                }
                else
                {
                    label3.Text = "Неверный логин или пароль";
                }
            }
            if (!flag)
            {
                string name = textBox1.Text;
                user2.Name = name;
                string lastpass = textBox2.Text;
                string newpassword = textBox3.Text;

                if (name == "" ||lastpass == "")
                {
                    MessageBox.Show("Не введен логин или пароль");
                }if (newpassword == "")
                {
                    MessageBox.Show("Не выбран новый пароль");
                }
                if(user1.Name == user2.Name && user1.Password == lastpass)
                {
                    user1.Password = newpassword;
                    user2.Password = newpassword;
                    label3.Text = "Вы сменили пароль";
                }
                else
                {
                    label3.Text = "Неправильный логин или пароль";
                }






            }
            

 
                




        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            textBox3.UseSystemPasswordChar = true;
            textBox2.UseSystemPasswordChar = true;
            flag = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (flag)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label2.Text = "Старый пароль";
                label3.Text = "";
                label4.Text = "Новый пароль";
                textBox3.Visible = true;
                button2.Text = "Сменить";
                flag = false;
                linkLabel1.Text = "Назад";
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label2.Text = "Пароль";
                label3.Text = "";
                label4.Text = "";
                button2.Text = "Войти";
                textBox3.Visible = false;
                flag = true;
                linkLabel1.Text = "Сбросить пароль";
            }
        }
    }
}
