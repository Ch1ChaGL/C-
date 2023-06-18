using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


namespace Химчистка
{
    public partial class CreateOrder : Form
    {
        SQL database = new SQL();

        public CreateOrder()
        {
            InitializeComponent();
            loadFromDatabase();

        }
        void loadFromDatabase()
        {
            database.LoadDataToCheckedListBox("select * from Markup", "MarkupId", "Name", markup);
            database.LoadDataToCheckedListBox("select * from Services", "ServicesId","Name", services);
            //Если таблица называется User (или другое ключевое слово), обязательно заключай ее в [], также если название состоит из нескольких разделенных слов [word word]
            database.LoadDataToComboBox("select * from [User]", "UserId", "Email", user);
            database.LoadDataToComboBox("select * from Branch", "BranchId", "Name", Branch);
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (fullName.Text == "" || email.Text == "") throw new Exception("Ошибка ввода данных, один из полей пропущен");

                string FullName = fullName.Text;
                string Email = email.Text;

                database.ExecuteNonQuery($"insert into [User] (FullName, Email, Category) values ('{FullName}', '{Email}', 1)", CommandType.Text);
                database.LoadDataToComboBox("select * from [User]", "UserId", "Email", user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            List<int> serviceIds = new List<int>();
            List<int> markupIds = new List<int>();
            double price = 0.0;
            foreach (var item in services.CheckedItems)
            {
                int id = int.Parse(((KeyValuePair<string, string>)item).Key);
                serviceIds.Add(id);
                price += (double)database.ExecuteScalar<decimal>($"select Cost from Services where ServicesId = {id}", CommandType.Text);
            }
            foreach (var item in markup.CheckedItems)
            {
                int id = int.Parse(((KeyValuePair<string, string>)item).Key);
                markupIds.Add(id);
                price += (double)(double)database.ExecuteScalar<decimal>($"select Cost Price from Markup where MarkupId = {id}", CommandType.Text);
            }
            FinalCost.Text = price.ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> serviceIds = new List<int>();
                List<int> markupIds = new List<int>();
                double price = 0.0;
                
                foreach (var item in services.CheckedItems)
                {
                    int id = int.Parse(((KeyValuePair<string, string>)item).Key);
                    serviceIds.Add(id);
                    price += (double)database.ExecuteScalar<decimal>($"select Cost from Services where ServicesId = {id}", CommandType.Text);
                }
                foreach (var item in markup.CheckedItems)
                {
                    int id = int.Parse(((KeyValuePair<string, string>)item).Key);
                    markupIds.Add(id);
                    price += (double)(double)database.ExecuteScalar<decimal>($"select Cost Price from Markup where MarkupId = {id}", CommandType.Text);
                }

                if (serviceIds.Count == 0) throw new Exception("Услуги не выбраны");
                
                var UserId = int.Parse(((KeyValuePair<string, string>)user.SelectedItem).Key);
                var BranchId = int.Parse(((KeyValuePair<string, string>)Branch.SelectedItem).Key);

                DateTime AceptedTime = dateTimePicker1.Value;
                string serviceIdsString = string.Join(",", serviceIds);
                string markupIdsString = string.Join(",", markupIds);

                database.ExecuteNonQuery($"exec CreateOrder {UserId}, {BranchId}, '{serviceIdsString}', '{markupIdsString}', '{AceptedTime}' ", CommandType.Text);
                MessageBox.Show("Заказ создан");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
