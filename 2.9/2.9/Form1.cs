using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string race = comboBox1.Text;
            string gun1 ="";
            string gun2 ="";
            string gun3 ="";
            if(checkBox1.CheckState == CheckState.Checked)
            {
                gun1 = "владеющий копьем !";
            }
            if(checkBox2.CheckState == CheckState.Checked)
            {
                gun2 = "разящий мечем !";
            }
            if(checkBox3.CheckState == CheckState.Checked)
            {
                gun3 = "познавший тайны магии !";
            }
            string answer = gun1 + gun2 + gun3;
            char[] arr = answer.ToCharArray();          
            for(int i =0; i < arr.Length; i++)
            {
                if (arr[i] == '!')
                {
                    arr[i] = ',';
                }
                if (i == arr.Length - 1)
                {
                    arr[i] = '!';
                }
            }
            string answer2 = new string(arr);
            if (name != "" && race != "")
            {
                if (checkBox1.CheckState != CheckState.Checked && checkBox2.CheckState != CheckState.Checked && checkBox3.CheckState != CheckState.Checked)
                {
                    label3.Text = "Приветствую тебя, " + race + " " + name + "!";
                }
                else
                {
                    label3.Text = "Приветствую тебя, " + race + " " + name + "," + '\n' + answer2;
                }
            }
            else
            {
                MessageBox.Show("Введите имя и выберите рассу");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string race = comboBox1.Text;
            if (race == "Орк")
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            if(race == "Человек")
            {
                pictureBox1.Image = Properties.Resources._1;
            }
        }
    }
}
