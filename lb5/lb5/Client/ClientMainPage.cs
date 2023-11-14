using lb5.Controller;
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
            
            var res = ClientController.GetClientOrders(login);
            
            dataTable = res.DataTable;
            adapter = res.SqlDataAdapter;
            command = res.Command;

            dataGridView1.DataSource = dataTable;
        }

    }
}
