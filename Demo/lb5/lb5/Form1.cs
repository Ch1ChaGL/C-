using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lb5.Controller;
using lb5.Services;
using lb5.Client;
using lb5.Cashier;
using lb5.consts;
using SQLLib;
namespace lb5
{
    public partial class Form1 : Form
    {
        private string text = String.Empty;
        bool isNeedCaptha = false;
        int time = 15;
        public Form1()
        {
            InitializeComponent();
            VisibleCapthaGroup(false);
        }

        int InvalidLoginCount = 0;

        private void SiginIn_Click(object sender, EventArgs e)
        {


            if (isNeedCaptha && textCaptha.Text != text)
            {
                MessageBox.Show("Капча не введена или введена неправильно");
                return;
            };
            string login = Login.Text;
            string password = Password.Text;

            string realPass = "";

            var client = ClientController.getClientsByLogin(login);
            var cashier = CashierController.getCashierByLogin(login);

            if (!client.HasRows && !cashier.HasRows)
            {
                MessageBox.Show("Введенный логин неверен");
                return;
            };

            if (client.HasRows)
            {
                client.Read();
                realPass = client["Password"].ToString();
            }
            if (cashier.HasRows)
            {
                cashier.Read();
                realPass = cashier["Password"].ToString();
            }

            if (password != realPass)
            {
                LogStorageController.addLog(login, DateTime.Now, false);
                MessageBox.Show("Пароль введен неверно");
                VisibleCapthaGroup(true);
                GenerateCapthaFn();
                if (isNeedCaptha) InvalidLoginCount++;
                if (InvalidLoginCount == 2)
                {
                    timer1.Start();
                    EnableLoginGroup(false);
                    VisibleCapthaGroup(false);
                }
                if(InvalidLoginCount == 3)
                {
                    EnableLoginGroup(false);
                    VisibleCapthaGroup(false);
                    label4.Text = "Вы заблокированы до перезапуска приложения";
                }
                isNeedCaptha = true;
            }
            else
            {
                Form form = null;
                var type = AllServices.GetUserRole(login);
                switch (type)
                {
                    case Consts.UserType.Client:
                        Visible = false;
                        form = new ClientMainPage(login);
                        LogStorageController.addLog(login, DateTime.Now, true);
                        form.ShowDialog();
                        Visible = true;
                        break;
                    case Consts.UserType.Cashier:
                        Visible = false;
                        form = new CashierMainPage(login);
                        LogStorageController.addLog(login, DateTime.Now, true);
                        form.ShowDialog();
                        Visible = true;
                        break;
                }
            }

        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 60);
            int Ypos = rnd.Next(15, Height - 20);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void GenerateCaptha_Click(object sender, EventArgs e)
        {
            Captha.Image = CreateImage(Captha.Width, Captha.Height);
        }
        private void GenerateCapthaFn()
        {
            Captha.Image = CreateImage(Captha.Width, Captha.Height);
        }
        private void VisibleCapthaGroup(bool visible)
        {
            label3.Visible = visible;
            Captha.Visible = visible;
            GenerateCaptha.Visible = visible;
            textCaptha.Visible = visible;
            textCaptha.Text = "";
        }
        private void EnableLoginGroup(bool enable)
        {
            Login.Enabled = enable;
            Password.Enabled = enable;
            SiginIn.Enabled = enable;
            ShowPassword.Enabled = enable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label4.Text = $"Ваш вход заблокирован еще {time} сек";

            if(time == 0)
            {
                label4.Text = "";
                EnableLoginGroup(true);
                VisibleCapthaGroup(true);
                timer1.Stop();
            }
        }

        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            Password.PasswordChar = '\0';
        }

        private void ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            Password.PasswordChar = '*';
        }
    }
}
