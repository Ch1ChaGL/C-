using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
