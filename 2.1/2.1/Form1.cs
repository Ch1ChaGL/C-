using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(textBox1.Text);
            int count = int.Parse(textBox2.Text);
            double bascet = price * count;
            string answer2 = String.Format("Корзина покупок равна =  {0:C}", bascet);
            label5.Text = answer2;
        }
    }
}
