using SQLLib;
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

namespace lb5.Client
{
    public partial class ClientMainPage : Form
    {
        SQL database = new SQL();
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private SqlCommand command;
        public ClientMainPage(string login)
        {
            InitializeComponent();
            
            var res = database.ExecuteQuery("select * from Currency");
            
            dataTable = res.DataTable;
            adapter = res.SqlDataAdapter;
            command = res.Command;

            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Обновление изменений в базе данных
                database.UpdateData(adapter, dataTable, command);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
            }
        }
    }
}
