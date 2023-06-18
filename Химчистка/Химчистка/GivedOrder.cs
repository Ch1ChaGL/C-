using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Химчистка
{
    public partial class GivedOrder : Form
    {   
        SQL database = new SQL();
        public GivedOrder()
        {
            InitializeComponent();
            dataGridView1.DataSource = database.ExecuteQuery("select * from Orders where GivedTime is null", CommandType.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBox1.Text);
            database.ExecuteNonQuery($"Update Orders set GivedTime = '{DateTime.Now}' where OrderId = {id}", CommandType.Text);
        }
    }
}
