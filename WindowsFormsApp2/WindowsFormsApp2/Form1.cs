using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            int YButton = button1.Top;
            int X = label1.Left;
            int Y = label1.Top;
            Y += 5;
            label1.Location = new Point(X, Y);
            if (count % 2 == 0)
            {
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Blue;
            }
            label1.Text = "Меня вывели " + count + " раз";
            count++;
            if (Y >= YButton)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
