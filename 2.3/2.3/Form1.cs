using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double heightroof = double.Parse(textBox1.Text);
            int count = int.Parse(textBox2.Text);
            double height = double.Parse(textBox3.Text);
            double answer = Math.Round((count * height) + heightroof, 2);
            //string kolvo =count.ToString();
            string metrica = GetEnd(count);
            
            //char[] kolvo = (count.ToString()).ToCharArray();
            //if (kolvo.Length >= 2)
            //{
            //    if (kolvo[kolvo.Length - 1] == '2' || kolvo[kolvo.Length - 1] == '3' || kolvo[kolvo.Length - 1] == '4')
            //    {
            //        metrica = "х";
            //    }
            //    if (kolvo[kolvo.Length - 1] == '5' || kolvo[kolvo.Length - 1] == '6' || kolvo[kolvo.Length - 1] == '7'
            //      || kolvo[kolvo.Length - 1] == '8' || kolvo[kolvo.Length - 1] == '9' || kolvo[kolvo.Length - 1] == '0')
            //    {
            //        metrica = "ти";
            //    }
            //    if (kolvo[kolvo.Length - 1] == '1')
            //    {
            //        metrica = "ого";
            //    }
            //    if (kolvo[kolvo.Length - 2] == '1')
            //    {
            //        metrica = "ти";
            //    }
                
            //}

            label4.Text = "Высота "+count+"-"+metrica+" этажного дома равна "+ answer+"м";
        }
        private string GetEnd(int number)
        {
            if(((number % 100)>10) && ((number % 100) < 20)){
                return "ти";
            }
            if(number % 10 == 1)
            {
                return "го";
            }
            if((number % 10 == 2)||(number % 10 == 3)||(number % 10 == 4))
            {
                return "x";
            }
            if (number % 10 == 7) { return "и"; }
            return "ти";
        }
    }
}
