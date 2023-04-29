using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Задание_13Вариант
{
    public partial class Form1 : Form
    {
        Circle circle;
        public Form1()
        {
            InitializeComponent();
            circle = new Circle(pictureBox1, new RectangleF(30,30,300,100), 50, 50, 50, 50, 25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle.Draw();                     
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            circle.Move(x, y);

        }
    }
}
