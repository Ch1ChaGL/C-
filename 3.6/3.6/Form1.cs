using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox3.Text += "Клик**";
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text += "Двойной клик**";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox3.Text += "Получение фокуса**";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text += "Изменение в текстовом поле**";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox3.Text += "Потеря фокуса**";
        }
    }
}
