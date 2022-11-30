using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsNumber(ch) && ch != '\b')
            {
                e.Handled = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int answer = num1 / 10;
            int answer2 = num1 % 10;
            if(num1<10 || num1 > 99)
            {
                textBox1.Text = "";
                MessageBox.Show("Число не является двухзначным");
                return;

            }
            textBox2.Text = answer.ToString();
            textBox3.Text = answer2.ToString();
            textBox4.Text = (answer + answer2).ToString();
            textBox5.Text = (answer*answer2).ToString();
        }
    }
}
