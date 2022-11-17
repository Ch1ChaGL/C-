using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3
{
    public partial class Form1 : Form
    {
        int count = 0;
        int b1 = 5;
        int b2 = 5;
        int b3 = 5;
        int b4 = 5;
        int b5 = 5;
        int b6 = 5;
        int b7 = 5;
        int b8 = 5;
        int b9 = 5;

        static Form form2 = new Form();
        int width = form2.Size.Width;
        int height = form2.Size.Height;
        public Form1()
        {
            InitializeComponent();
          

        }

        private void button9_Click(object sender, EventArgs e)
        {

            
            Button button = (Button)sender;
            
                if (button.Name == button1.Name)
                {
                    label1.Top -= b1;
                    label1.Left -= b1;
                    //label1.Location = new Point(313-b1, 35-b1);
                    b1 += 5;
                }
                if (button.Name == button2.Name)
                {
                    label1.Top -= b2;
                //label1.Location = new Point(370, 35-b2);
                b2 += 5;
                }
                if (button.Name == button3.Name)
                {
                label1.Top -= b3;
                label1.Left += b3;
                // label1.Location = new Point(430+b3, 35-b3);
                b3 += 5;
                }
                if (button.Name == button4.Name)
                {
                    label1.Left -= b4;
                    // label1.Location = new Point(313-b4, 118);
                    b4 += 5;
            }
                if (button.Name == button5.Name)
                {
                //label1.Location = new Point(370, 118);
                int x = width / 2;
                int y = height / 2;
                label1.Left = 529;
                label1.Top = 263;

                b1 = 0;
                b2 = 0;
                b3 = 0;
                b4 = 0;
                b5 = 0;
                b6 = 0;
                b7 = 0;
                b8 = 0;
                b9 = 0;
            }
                if (button.Name == button6.Name)
                {
                label1.Left += b6;                
                    //label1.Location = new Point(430+b6, 118);
                b6 += 5;
                }
                if (button.Name == button7.Name)
                {
                    label1.Left -= b7;
                    label1.Top += b7;
                    //label1.Location = new Point(313+b7, 170+b7);
                    b7 += 5;
                }
                if (button.Name == button8.Name)
                {
                label1.Top += b8;
                // label1.Location = new Point(370+b8, 170+b8);
                b8 += 5;
                }
                if (button.Name == button9.Name)
                {
                label1.Left += b9;
                label1.Top += b9;
                //label1.Location = new Point(430+b9, 170+b9);
                b9 +=5;
                }
            
        }
    }
}
