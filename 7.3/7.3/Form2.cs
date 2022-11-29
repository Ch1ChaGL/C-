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
                try
                {
                    return new Size(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                catch
                {
                    return new Size(500, 500);
                }
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

        public int startPosition
        {
             
            get 
            {
                

                //if(comboBox1.SelectedIndex == 0)
                //{
                if(comboBox1.Text == "по центру")
                {
                    return 0;
                }
                if (comboBox1.Text == "сверху по центру")
                {
                    return 1;
                }
                if (comboBox1.Text == "снизу по центру")
                {
                    return 2;
                }
                else
                {
                    return 3;
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
