using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2
{   

    public partial class Form1 : Form
    {
      
        Boolean format10 = true;
        Boolean format2 = false;
        Boolean format8 = false;
        Boolean format16 = false;
        public Form1()
        {
            InitializeComponent();
        }
        private int format2n(int num1, int num2)
        {
            if(num1 == 1 && num2 == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
      
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if(radioButton.Text == "10-ричная")
            {
                format10 = true;
                format2 = false;
                format8 = false;
                format16 = false;
                label1.Text = "Введите текст в 10 системе";
                textBox1.Clear();
                label2.Text = "";

            }
            if (radioButton.Text == "8-ричная")
            {
                format10 = false;
                format2 = false;
                format8 = true;
                format16 = false;             
                label1.Text = "Введите текст в 8 системе";
                textBox1.Clear();
                label2.Text = "";
            }
            if (radioButton.Text == "2-ичная")
            {
                format10 = false;
                format2 = true;
                format8 = false;
                format16 = false;             
                label1.Text = "Введите текст в 2 системе";
                textBox1.Clear();
                label2.Text = "";
            }
            if (radioButton.Text == "16-ричная")
            {
                format10 = false;
                format2 = false;
                format8 = false;
                format16 = true;              
                label1.Text = "Введите текст в 16 системе";
                textBox1.Clear();
                label2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (format10)
            {
                char[] num1 = new char[textBox1.Text.Length];
                num1 = textBox1.Text.ToCharArray();
                if (num1.Length < 2)
                {
                    label2.Text = "Число не подподает под задание";
                }
                else
                {
                    int answer4 = (Convert.ToInt32(num1[0]) - 48) * Convert.ToInt32(num1[1] - 48);
                    int answer3 = (Convert.ToInt32(num1[0]) - 48) * Convert.ToInt32(num1[num1.Length - 1] - 48);
                    int answer2 = (Convert.ToInt32(num1[num1.Length - 1]) - 48) * Convert.ToInt32(num1[num1.Length - 2] - 48);
                    label2.Text = $"Резултат произведения первого и последнего числа равна {answer3} \nРезултат произведения первого и второго числа равна {answer4} \nРезультат произведения последних двух цифр {answer2}";
                }
            }
            if (format2) {
                int answer,answer2,answer3,answer4;
                char[] num1 = new char[textBox1.Text.Length];
                num1 = textBox1.Text.ToCharArray();
                if (num1.Length < 2)
                {
                    label2.Text = "Число не подподает под задание";
                }
                else
                {
                   answer = format2n(num1[0] - 48, num1[textBox1.Text.Length-1] - 48);
                   answer2 = format2n(num1[0] - 48, num1[1]- 48);
                   answer3 = format2n(num1[textBox1.Text.Length - 1] - 48, num1[textBox1.Text.Length - 2] - 48);
                    label2.Text = $"Произведение первого и последнего числа в двоичной системе\nравна {answer}\n" +
                        $"Произведение первых двух чисул в двоичной системе\nравна {answer2}\n"+
                        $"Произведение последних двух чисул в двоичной системе\nравна {answer3}\n";
                }
                
            }
            if (format8) {
                int answer, answer2, answer3, answer4;
                char[] num1 = new char[textBox1.Text.Length];
                num1 = textBox1.Text.ToCharArray();
                if (num1.Length < 2)
                {
                    label2.Text = "Число не подподает под задание";
                }
                else
                {
                    answer = Convert.ToInt32(num1[0] - 48) * Convert.ToInt32(num1[textBox1.Text.Length - 1] - 48);
                    answer2 = Convert.ToInt32(num1[0] - 48) * Convert.ToInt32(num1[1] - 48);
                    answer3 = Convert.ToInt32(num1[textBox1.Text.Length - 1] - 48) * Convert.ToInt32(num1[textBox1.Text.Length - 2] - 48);
                    label2.Text = $"Резултат произведения первого и последнего числа равна {Convert.ToString(answer,8)} \nРезултат произведения первого и второго числа равна {Convert.ToString(answer2, 8)} \nРезультат произведения последних двух цифр {Convert.ToString(answer3, 8)}";
                }


            }
            if (format16) {
                int answer, answer2, answer3, answer4;
                char[] num1 = new char[textBox1.Text.Length];
                num1 = textBox1.Text.ToCharArray();
                if (num1.Length < 2)
                {
                    label2.Text = "Число не подподает под задание";
                }
                else
                {
                    if (num1[0] - 48 > 15)
                    {
                        answer = num1[0] - 55;
                    }
                    else
                    {
                        answer = Convert.ToInt32(num1[0] - 48);
                    }
                    if (num1[1] - 48 > 15)
                    {
                        answer2 = num1[1] - 55;
                    }
                    else
                    {
                        answer2 = Convert.ToInt32(num1[1] - 48);
                    }
                    if (num1[textBox1.Text.Length - 1] - 48 > 15)
                    {
                        answer3 = num1[textBox1.Text.Length-1] - 55;
                    }
                    else
                    {
                        answer3 = Convert.ToInt32(num1[textBox1.Text.Length - 1] - 48);
                    }
                    if (num1[textBox1.Text.Length - 2] - 48 > 15)
                    {
                        answer4 = num1[textBox1.Text.Length-2] - 55;
                    }
                    else
                    {
                        answer4 = Convert.ToInt32(num1[textBox1.Text.Length - 2] - 48);
                    }

                    label2.Text = $"Произведение 1 и последнего числа = {Convert.ToString(answer*answer3,16)} \n" +
                        $"Произведение 1 и 2 числа = {Convert.ToString(answer * answer2, 16)} \n" + 
                        $"Произведение двух последних чисел = {Convert.ToString(answer4 * answer3, 16)} \n";







                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (format10) {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            if (format2) {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '1') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            if (format8) {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '7') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            if (format16) {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9')&& !(e.KeyChar >= 'A' && e.KeyChar <= 'F') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
