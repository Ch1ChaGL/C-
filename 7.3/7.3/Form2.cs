using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _7._3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Color FormColor
        {
            get
            {
                return label4.BackColor;
            }
        }

        public Size FormSize
        {
            get
            {   
                return new Size(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            }
        }

        public FormWindowState Maximizade
        {
            get
            {
                if (comboBox1.SelectedIndex == 3)
                {
                    return FormWindowState.Maximized;
                }
                else
                {
                    return FormWindowState.Normal;
                }
            }

        }

        public FormStartPosition startPosition
        {
            get 
            { 
                if(comboBox1.SelectedIndex == 0)
                {
                    return FormStartPosition.CenterScreen;

                }
                if(comboBox1.SelectedIndex == 1)
                {

                    return FormStartPosition.Manual;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    return  FormStartPosition.Manual;
                }
                else
                {
                    return FormStartPosition.Manual;
                }


            }
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label4.BackColor = colorDialog1.Color;
            }
        }
    }
}
