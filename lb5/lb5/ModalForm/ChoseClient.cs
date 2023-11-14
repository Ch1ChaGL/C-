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
    public partial class ChoseClient : Form
    {
        public int ClientID = 0;
        public int getClient()
        {
            return ClientID;
        }
        public ChoseClient()
        {
            InitializeComponent();
            dataGridView1.DataSource = ClientController.getClientsToDataTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Получаем значение первой ячейки в строке
                object value = selectedRow.Cells[0].Value;

                ClientID = int.Parse(value.ToString());

            }
        }

        private void Chose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
