using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double width = double.Parse(textBox1.Text);
            double height = double.Parse(textBox2.Text);
            double cost = ((width * height) * 4000);
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                m1 = 1500;
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                m2 = 650;
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                m3 = 500;
            }
            cost = cost + m1 + m2 + m3;
            label3.Text = $"Сумма стеклопакета равна = {cost:c}";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

           e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || (e.KeyChar.Equals(',')) && (!textBox1.Text.Contains(',') && textBox1.Text.Length != 0));

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)||e.KeyChar == '\b' || (e.KeyChar.Equals(',')) && (!textBox2.Text.Contains(',') && textBox2.Text.Length != 0));
        }


    }
}

