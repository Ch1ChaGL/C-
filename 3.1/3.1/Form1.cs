using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //    button1.Width = Cursor.Position.X;
            //    button1.Height = Cursor.Position.Y;
            //int width = Cursor.Position.X;
            //int height = Cursor.Position.Y;
            //button1.SetBounds(0, 0, width, height);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            //Cursor.Position = new Point(button1.Width, button1.Height);
            //int width = Cursor.Position.X;
            //int height = Cursor.Position.Y;
            //button1.SetBounds(0, 0, width, height);
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(0,0);

        }

        private void button1_Resize(object sender, EventArgs e)
        {
            //Cursor.Position = new Point(button1.Width, button1.Height);
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_ClientSizeChanged(object sender, EventArgs e)
        {

          
        }

        private void button1_CursorChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {//
           // button1.Width = Cursor.Position.X;
           // button1.Height = Cursor.Position.Y;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.Width = Cursor.Position.X;
           // button1.Height = Cursor.Position.Y;
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
          
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
           
            button1.Width = Cursor.Position.X;
            button1.Height = Cursor.Position.Y;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
