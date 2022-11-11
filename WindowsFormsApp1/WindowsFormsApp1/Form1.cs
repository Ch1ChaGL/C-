using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double max = 30.0;
            double min = 1.0;

            double Height = random.NextDouble() * (max - min) + min;
            double Width = random.NextDouble() * (max - min) + min;
            Height = Math.Round(Height, 1);
            Width = Math.Round(Width, 1);
            double S = Height * Width;
            String answer = "Площадь прямоугольника со сторонами " + Height + " X " + Width + "см равна " + S + "кв.см";
            label1.Text= answer;
        }
    }
}
