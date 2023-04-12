using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ФормаКурьерскойБД
{
    public partial class DepartmentOrder : Form
    {
        int _departmentId;
        string sql;
        public DepartmentOrder(int departmentId)
        {
            InitializeComponent();
            _departmentId = departmentId;
        }
        deliveryServiceDatabase database = new deliveryServiceDatabase();
        private void заказыБезКурьеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"exec dbo.GetOrdersWithoutCourier {_departmentId}", CommandType.Text);
        }

        private void DepartmentOrder_Load(object sender, EventArgs e)
        {
            sql = $"select IdCourier, FullName from Couriers where DepartmentId = {_departmentId}";
            var dataTable = database.ExecuteQuery(sql, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                var idCourier = row["idCourier"].ToString();
                var fullName = row["FullName"].ToString();
                courierList.Items.Add(new KeyValuePair<string, string>(idCourier, fullName));
            }
        }

        private void AddCourier_Click(object sender, EventArgs e)
        {
            database.ExecuteNonQuery($"exec dbo.AddCourierToOrder {int.Parse(OrderId.Text)}, {int.Parse(((KeyValuePair<string, string>)courierList.SelectedItem).Key)}", CommandType.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database.ExecuteNonQuery($"exec dbo.UpdateOrderStatus {int.Parse(OrderId.Text)}, 5", CommandType.Text);
        }

        private void курьерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"select * from Couriers where DepartmentId = {_departmentId}", CommandType.Text);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"select * from Clients", CommandType.Text);
        }

        private void отправленныеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"exec dbo.getOrderInDepartment {_departmentId}", CommandType.Text);
        }

        private void SearchCourierEmail_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"select * from Couriers where Email = '{CourierEmail.Text}'", CommandType.Text);
        }

        private void SearchClientEmail_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"select * from Clients where Email = '{ClientsEmail.Text}'", CommandType.Text);
        }

        private void SearchOrderId_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"select * from Orders where IdOrder = {int.Parse(OrderIDSearch.Text)}", CommandType.Text);
        }

        private void SearchOrderIdClent_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"exec dbo.getOrderClientId {int.Parse(SearchOrderClientId.Text)}", CommandType.Text);
        }
    }
}
