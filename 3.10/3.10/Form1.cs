using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._10
{
   
    public partial class Form1 : Form
    {
        string lastkey;
        private bool isAuto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {  
            bool W = char.ToUpper(e.KeyChar) == (char)Keys.W  ;
            bool S = char.ToUpper(e.KeyChar) == (char)Keys.S ;
            bool A = char.ToUpper(e.KeyChar) == (char)Keys.A;
            bool D = char.ToUpper(e.KeyChar) == (char)Keys.D ;
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyChar == 13)
                pictureBox1.Location = new Point(0, 0);
            if (e.KeyChar == 27)
                Environment.Exit(1);
            if(W && pictureBox1.Location.Y >= 0) {
                pictureBox1.Location = new Point(x,y-5);
                lastkey = "w";
            }
            if (S && pictureBox1.Location.Y + pictureBox1.Height <= this.Height) {
                pictureBox1.Location = new Point(x, y + 5);
                lastkey = "s";
            }
            if (A && pictureBox1.Location.X >= 0) {
                pictureBox1.Location = new Point(x - 5, y);
                lastkey = "a";
            }
            if (D && pictureBox1.Location.X + pictureBox1.Width < this.Width) {
                pictureBox1.Location = new Point(x+5, y);
                lastkey="d";
            }
            if (pictureBox1.Location.Y + pictureBox1.Height > this.Height || pictureBox1.Location.Y < 0
                || pictureBox1.Location.X + pictureBox1.Width > this.Width || pictureBox1.Location.X < 0) pictureBox1.Image = Properties.Resources.заяц_с_морковкой;
            else pictureBox1.Image = Properties.Resources.заяц;


            if (e.KeyChar == (char)Keys.Tab)
            {
                isAuto = !isAuto;
                if (isAuto)
                    timer1.Start();
                else
                    timer1.Stop();
            }
        }
 


        private void timer1_Tick(object sender, EventArgs e)
        {
          
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (lastkey == "w")
            {
                if (pictureBox1.Location.Y >= 0)
                {
                    pictureBox1.Location = new Point(x, y - 5);
                }
            }
            if(lastkey == "s")
            {
                if(pictureBox1.Location.Y + pictureBox1.Height <= this.Height)
                {
                    pictureBox1.Location = new Point(x, y + 5);
                }
            }
            if(lastkey == "a")
            {
                if (pictureBox1.Location.X >= 0)
                {
                    pictureBox1.Location = new Point(x - 5, y);
                }
            }
            if(lastkey == "d")
            {
                if (pictureBox1.Location.X + pictureBox1.Width < this.Width)
                {
                    pictureBox1.Location = new Point(x + 5, y);

                }
            }
            if (pictureBox1.Location.Y + pictureBox1.Height > this.Height || pictureBox1.Location.Y < 0
              || pictureBox1.Location.X + pictureBox1.Width > this.Width || pictureBox1.Location.X < 0) pictureBox1.Image = Properties.Resources.заяц_с_морковкой;
            else pictureBox1.Image = Properties.Resources.заяц;
        }
    }
}
