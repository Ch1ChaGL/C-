using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           RadioButton radioButton = (RadioButton)sender;
            if(radioButton.Text == "естественный" && radioButton.Checked)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Pink;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Text == "красный" && radioButton.Checked) label1.ForeColor = Color.Red;
            if (radioButton.Text == "синий" && radioButton.Checked) label1.ForeColor = Color.Blue;
            if (radioButton.Text == "белый" && radioButton.Checked) label1.ForeColor = Color.White;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Text == "розовый" && radioButton.Checked) label1.BackColor = Color.Pink;
            if (radioButton.Text == "голубой" && radioButton.Checked) label1.BackColor = Color.Blue;
            if (radioButton.Text == "мой любимый цвет" && radioButton.Checked)
            {
                if(colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    label1.BackColor = colorDialog1.Color;
                }


            };
        }
    }
}
