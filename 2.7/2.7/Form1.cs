using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._7
{
    public partial class Form1 : Form
    {
        struct Point
        {
            public double X;
            public double Y;
        }
        public Form1()
        {
            
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
         Point point1 = new Point();
         Point point2 = new Point();
            point1.X = double.Parse(textBox1.Text);
            point1.Y = double.Parse(textBox2.Text);
            point2.X = double.Parse(textBox3.Text);
            point2.Y = double.Parse(textBox4.Text);
            double answer = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            label7.Text = $" Расстояние между А({point1.X}:{point1.Y}) и B({point2.X}:{point2.Y}) = {Math.Round(answer,2)} ";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                button1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox2.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                button1.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                button1.Enabled = true;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                button1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            button1.Enabled = false;
           
        }
    }
}
