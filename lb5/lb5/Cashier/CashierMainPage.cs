using lb5.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lb5.ModalForm;

namespace lb5.Cashier
{
    public partial class CashierMainPage : Form
    {
        SqlDataAdapter adapter;
        DataTable dataTable;
        SqlCommand command;
        public int clientID = 0;
        string cashierLogin = "";
        public CashierMainPage(string login)
        {
            InitializeComponent();
            cashierLogin = login;
            var res = CurrencyController.GetCurrency();
            adapter = res.SqlDataAdapter;
            dataTable = res.DataTable;
            command = res.Command;
            Currency.DataSource = res.DataTable;

            CurrencyController.LoadCurrencyToComboBox(TargetCurrency);
            CurrencyController.LoadCurrencyToComboBox(ClientCurrency);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            Visible = false;
            loginForm.ShowDialog();
            Visible = true;
        }

        private void choseClient_Click(object sender, EventArgs e)
        {
            ChoseClient form = new ChoseClient();
            form.Owner = this;
            Visible = false;
            form.ShowDialog();
            clientID = form.ClientID;
            Visible = true;

            if (clientID != 0)
            {
                loadClientsToDataGridView();
            }
        }

        private void loadClientsToDataGridView()
        {
            dataGridView1.DataSource = ClientController.getClientsByLoginToDataTable(clientID);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (ClientCurrency.Text == TargetCurrency.Text)
            {
                MessageBox.Show("Выберите разные валюты");
                return;
            }


            int clientCurrncyCount = int.Parse(ClientCurrencyCount.Text);

            double ClientPurchaseRate = CurrencyController.GetPurchaseRate(ClientCurrency.Text);
            double ClientSellingRate = CurrencyController.GetSellingRate(ClientCurrency.Text);

            double TargetPurchaseRate = CurrencyController.GetPurchaseRate(TargetCurrency.Text);



            if (ClientCurrency.Text == "RUB")
            {
                var num = Math.Round((clientCurrncyCount / TargetPurchaseRate), 2);
                
                textBox3.Text = $"{num} {TargetCurrency.Text}";
            }
            if (ClientCurrency.Text != "RUB")
            {
                var rub = clientCurrncyCount * ClientSellingRate;
                var num = Math.Round(rub / TargetPurchaseRate, 2);



                textBox3.Text = $"{num} {TargetCurrency.Text}";
            }
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            if(OrderController.createOrder(ClientCurrency.Text, TargetCurrency.Text, clientID, double.Parse(ClientCurrencyCount.Text), cashierLogin))
            {
                MessageBox.Show("Заказ успешно закрыт");
            }
            else
            {
                MessageBox.Show("Произошла ошибка, попробуйте еще");
            }
        }
    }
}
