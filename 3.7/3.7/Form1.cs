using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace _3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            textbox.BackColor = Color.LightPink;
            if(textbox.Name == "textBox2")
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
            }
            if(textbox.Name == "textBox3") {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
            }
            
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            textbox.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as TextBox;
            if(textbox.Name == "textBox1") {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }               
            }
            if (textbox.Name == "textBox2") {
                if (textbox.Name == "textBox2")
                {
                    if (!(e.KeyChar >= 'A' && e.KeyChar <= 'z') && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
            }
            if (textbox.Name == "textBox3")
            {
                if (textbox.Name == "textBox3")
                {
                    if (!(e.KeyChar >= 'А' && e.KeyChar <= 'я') && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
           
        }
    }       
}
