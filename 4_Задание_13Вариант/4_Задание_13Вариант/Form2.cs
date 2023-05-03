using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _4_Задание_13Вариант.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4_Задание_13Вариант
{
    public partial class Form2 : Form
    {
        
        Form1 f;
        Direction Direction1;
        Color color11;
        Color color22;
        public Form2()
        {
            InitializeComponent();
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            speed.Minimum = 10;
            speed.Maximum = 100;
            speed.SmallChange = 1;
            speed.RightToLeft = RightToLeft.Yes;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void vertically_CheckedChanged_1(object sender, EventArgs e)
        {

            if(horizontally.Checked == true)
            {
                Form1 f = (Form1)Owner;
                f.MyDirection = Direction.Left;
            }
            if(vertically.Checked == true)
            {
                Form1 f = (Form1)Owner;
                f.MyDirection= Direction.Up;
            }
        }

        private void color1_Click(object sender, EventArgs e)
        {
            var btn = (System.Windows.Forms.Button)sender;
            if(btn.Name == "color1")
            {
                if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                Form1 f = (Form1)Owner;
                f.Color1 = colorDialog1.Color;

            }
            else if(btn.Name == "color2")
            {
                if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                Form1 f = (Form1)Owner;
                f.Color2 = colorDialog1.Color;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            f.MyDirection = Direction1;
            f.Color1 = color11; 
            f.Color2 = color22;

            Close();
        }

        private void speed_Scroll(object sender, EventArgs e)
        {
            Form1 f = (Form1)Owner;
            f.Speed = speed.Value;
        }
    }
}
