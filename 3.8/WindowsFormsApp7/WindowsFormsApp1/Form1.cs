using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {

            var lav = sender as Label;
            lav.BackColor = Color.Pink;
            label5.Text =  $"Мышка находится {lav.Text}";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            var lav = sender as Label;
            lav.BackColor = Color.White;
            label5.Text = "Мышка вне квадрантов";
        }
    }
}
