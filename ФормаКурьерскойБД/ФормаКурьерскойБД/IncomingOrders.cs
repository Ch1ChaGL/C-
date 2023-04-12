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
    public partial class IncomingOrders : Form
    {
        int _idDepartment;
        deliveryServiceDatabase database = new deliveryServiceDatabase();
        public IncomingOrders(int IdDepartment)
        {
            InitializeComponent();
            _idDepartment = IdDepartment;
        }

        private void Delivered_Click(object sender, EventArgs e)
        {
            database.ExecuteNonQuery($"exec dbo.UpdateOrderStatus {int.Parse(idOrder.Text)}, 3", CommandType.Text); 
        }

        private void Received_Click(object sender, EventArgs e)
        {
            database.ExecuteNonQuery($"exec dbo.InsertReport {int.Parse(idOrder.Text)}, {_idDepartment}", CommandType.Text);
        }

        private void поступающиеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"exec getOrderReceive {_idDepartment}, 'В пути'", CommandType.Text);
        }

        private void заказыНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"exec getOrderReceive {_idDepartment}, 'Доставлен'", CommandType.Text);
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ExecuteQuery($"select * from Reports where DepartmentId = {_idDepartment}", CommandType.Text);
        }
    }
    
}
