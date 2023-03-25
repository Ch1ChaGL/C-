using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba15;

namespace laba15Form
{
    public partial class Form1 : Form
    {
        string optionsM1;
        string optionsM2;
        Arr a;
        Arr b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;

            M1N1.Enabled = !(M1option1.Checked || M1option4.Checked);
            M1N2.Enabled = !((M1option1.Checked || M1option4.Checked) || M1option2.Checked);

            optionsM1 = radio.Text;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;

            M2N1.Enabled = !(M2option1.Checked || M2option4.Checked);
            M2N2.Enabled = !((M2option1.Checked || M2option4.Checked) || M2option2.Checked);

            optionsM2 = radio.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn == btn1)
            {
                plusM1.Enabled = minusM1.Enabled = true;
                
                int size = (int)numericUpDown1.Value;
                a = new Arr(size);
                if (M1option1.Checked)
                {
                    a.RndInput();
                }
                else if (M1option2.Checked)
                {
                    a.RndInput(int.Parse(M1N1.Text));
                }
                else if (M1option3.Checked)
                {
                    a.RndInput(int.Parse(M1N1.Text), int.Parse(M1N2.Text));
                }else if (M1option4.Checked)
                {
                    a.ReadFile();
                }
                a.Print(MassM1);
                labelM1.Text = $"Массив M1 [{size}]";
            }
            else
            {
                plusM2.Enabled = minusM2.Enabled  = true;
                int size = (int)numericUpDown2.Value;
                b = new Arr(size);
                if (M2option1.Checked)
                {
                    b.RndInput();
                }
                else if (M2option2.Checked)
                {
                    b.RndInput(int.Parse(M2N1.Text));
                }
                else if (M2option3.Checked)
                {
                    b.RndInput(int.Parse(M2N1.Text), int.Parse(M2N2.Text));
                }
                else if (M2option4.Checked)
                {
                    b.ReadFile();
                }
                b.Print(MassM2);
                labelM2.Text = $"Массив M2 [{size}]";
            }
            
        }

        private void plusM1_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if(btn == plusM1)
            {
                a++;
                a.Print(MassM1);
            }
            else if(btn == minusM1)
            {
                a--;
                a.Print(MassM1);
            }
            else if(btn == plusYM1)
            {
                a = a + int.Parse(YM1.Text);
                a.Print(MassM1);
            }else if(btn == minusYM1)
            {
               a = a - int.Parse(YM1.Text);
                a.Print(MassM1);
            }

        }

        private void YM1_TextChanged(object sender, EventArgs e)
        {
            plusYM1.Enabled = minusYM1.Enabled = YM1.Text != "" && MassM1.ColumnCount != 0;
            plusYM2.Enabled = minusYM2.Enabled = YM2.Text != "" && MassM2.ColumnCount != 0;
        }

        private void plus_Click(object sender, EventArgs e)
        { 
            if(a == null || b == null)
            {
                return;
            }
            string operation; 
            var btn = sender as Button;
            if (btn == plus)
            {
                Arr temp = a + b;
                temp.Print(sum);
                operation = "Сумма";
            }
            else
            {
                operation = "Разность";
                Arr temp = a - b;
                temp.Print(sum);
            }
            label9.Text = $"{operation} двух массивов";
        }

        private void plusM2_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn == plusM2)
            {
                b++;
                b.Print(MassM2);
            }
            else if (btn == minusM2)
            {
                b--;
                b.Print(MassM2);
            }
            else if (btn == plusYM2)
            {
                b = b + int.Parse(YM2.Text);
                b.Print(MassM2);
            }
            else if (btn == minusYM2)
            {
                b = b - int.Parse(YM2.Text);
                b.Print(MassM2);
            }

        }

        private void ZM1_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn == ZM1)
                AM1.Text = $"Y = {a.GetY()}";
            else
                AM2.Text = $"Y = {b.GetY()}";
            
        }
    }
}
