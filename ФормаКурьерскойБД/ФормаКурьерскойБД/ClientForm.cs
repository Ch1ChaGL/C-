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

namespace ФормаКурьерскойБД
{
    public partial class ClientForm : Form
    {
        int idClient;
        public ClientForm(int id)
        {
            InitializeComponent();
            idClient = id;
        }
    
        
        deliveryServiceDatabase database = new deliveryServiceDatabase();
        DataTable datatable;
        private void Services_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Name, Price, Description FROM AdditionalServices";
            SqlDataReader reader = database.ExecuteReader(sql, CommandType.Text);

            if (reader.HasRows)
            {
                datatable = database.ExecuteQuery(sql, CommandType.Text);
                dataGridView.DataSource = datatable;
            }
            else
            {
                MessageBox.Show("Дополнительных услуг нет");
            }
        }

        private void BaseCost_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Distance, Cost FROM BaseCosts";
            SqlDataReader reader = database.ExecuteReader(sql, CommandType.Text);

            if (reader.HasRows)
            {
                datatable = database.ExecuteQuery(sql, CommandType.Text);
                dataGridView.DataSource = datatable;
            }
            else
            {
                MessageBox.Show("Базовых тарифов нет");
            }
        }

        private void CargoType_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Name,Description, CostCoefficient FROM CargoTypes";
            SqlDataReader reader = database.ExecuteReader(sql, CommandType.Text);

            if (reader.HasRows)
            {
                datatable = database.ExecuteQuery(sql, CommandType.Text);
                dataGridView.DataSource = datatable;
            }
            else
            {
                MessageBox.Show("Типов груза нет");
            }
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM dbo.GetOrdersBasicInfo({idClient});\r\n";
            SqlDataReader reader = database.ExecuteReader(sql, CommandType.Text);
            if (reader.HasRows)
            {
                datatable = database.ExecuteQuery(sql, CommandType.Text);
                dataGridView.DataSource = datatable;
            }
            else
            {
                dataGridView.DataSource = "";
            }
        }

        private void OrderInfo_Click(object sender, EventArgs e)
        {
            if (idOrder.Text == "") return;
            int idOrderValue = int.Parse(idOrder.Text);
            string sql = $"select * from dbo.GetOrderInfo({idOrderValue},{idClient})";

            SqlDataReader reader = database.ExecuteReader(sql, CommandType.Text);

            if (reader.HasRows)
            {
                datatable = database.ExecuteQuery(sql, CommandType.Text);
                dataGridView.DataSource = database.TransposeDataTable(datatable);
            }
            else
            {
                dataGridView.DataSource = "";
                MessageBox.Show($"Заказа с номером {idOrderValue} не существует");
            }
           
        }
    }
}
