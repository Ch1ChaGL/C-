using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2._6
{
    public partial class Form1 : Form
    {
        int time = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();    
        }
       
    private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
                
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int answer1 = num1 + num2;
                int answer2 = num1 - num2;
                int answer3 = num1 * num2;
                int answer4 = num1 / num2;
                int answer5 = num1 - (answer4 * num2);
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }


                time++;
                string text1 = num1 + " + " + num2 + " = " + answer1+" \n";
                string text2 = num1 + " - " + num2 + " = " + answer2+" \n";
                string text3 = num1 + " * " + num2 + " = " + answer3+" \n";
                string text4 = num1 + " / " + num2 + " = " + answer4 + " остаток " + answer5 + "\n";
                if (time == 1)
                {   
                   
                    label1.Text = text1;                                       
                }
                if(time == 2)
                {
                    
                    label1.Text = text1 + text2;
                }
                if(time == 3)
                {
                    label1.Text = text1 + text2+ text3;
                }
                if(time == 4)
                {
                    label1.Text = text1 + text2 + text3 + text4;
                }
                if(time > 4)
                {
                   time = 0;
                    button1.Enabled = true;
                    timer1.Enabled = false;
                }

            }
            catch (FormatException) { MessageBox.Show("Не верный формат"); }
            catch (DivideByZeroException) { MessageBox.Show("На ноль делить нельзя"); }
           

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
