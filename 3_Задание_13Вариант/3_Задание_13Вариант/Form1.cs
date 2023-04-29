using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Задание_13Вариант
{
    public partial class Form1 : Form
    {
        Circle circle;
        Rectangle rectangle;
        Square square;
        Triangle triangle;
        public Form1()
        {
            InitializeComponent();
            circle = new Circle(pictureBox1, new RectangleF(30,30,300,100), 50, 50, 25);
            rectangle = new Rectangle(pictureBox1, new RectangleF(30, 30, 300, 300), 150, 150, 100, 50);
            square = new Square(pictureBox1, new RectangleF(30, 30, 300, 300), 30, 30, 100);
            triangle = new Triangle(pictureBox1, new RectangleF(30, 30, 300, 300), 30, 30, new Point(100, 150), new Point(150, 50), new Point(200, 150));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle.Draw();
            square.Draw();
            if(rectangle >= square)
            {
                Console.WriteLine("rectangle >= square");
            }
            else if(rectangle <= square)
            {
                Console.WriteLine("rectangle <= square");
            }
            triangle.Draw();
            //square.Rotate(30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            triangle.Rotate(int.Parse(textBox1.Text));
            //int x = int.Parse(textBox1.Text);
            //int y = int.Parse(textBox2.Text);

            //circle.Move(x, y);

        }
    }
}
