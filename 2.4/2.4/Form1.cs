using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double delimoe = double.Parse(textBox1.Text);
            double delitel = double.Parse(textBox2.Text);
            if(delitel == 0)
                {
                    throw new DivideByZeroException();
                    
                }
            double answer1 = delimoe / delitel;
            double answer2 = Math.Truncate(answer1);
            double answer3 = delimoe-(answer2*delitel);
            linkLabel1.Text = "Частное " + answer1 +"\n"+"Целая часть "+ answer2+"\n"+
                    "Остаток от деления "+answer3;



            }
            catch (DivideByZeroException) { linkLabel1.Text = ""; MessageBox.Show("На ноль делить нельзя");  }
            catch (FormatException) { linkLabel1.Text = "";  MessageBox.Show("Не верный формат");  }
           
        }
    }
}
