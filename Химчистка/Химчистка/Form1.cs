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
    public partial class Form1 : Form
    {
        SQL database = new SQL();
        public Form1()
        {
            InitializeComponent();
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            Visible = false;
            var co = new CreateOrder();
            co.ShowDialog();
            Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            var go = new GivedOrder();
            go.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
