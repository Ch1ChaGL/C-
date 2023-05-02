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
        Triangle triangle;
        Square square;
        Rectangle rectangle;
        bool containerField;
        bool triangleField;
        bool squareField;
        bool rectangleField;
        bool circleField;
        public Form1()
        {
            InitializeComponent();
            
        }
        
    
        
        float containerX;
        float containerY;
        float containerWidth;
        float containerHeight;

        Figure figureA;
        Figure figureB;
        Figure currentFigure;
        

        private void compare_Click(object sender, EventArgs e)
        {
            if(figureA == figureB)
            {
                MessageBox.Show("Фигура A = Фигура Б");
            }
            else if(figureA > figureB)
            {
                MessageBox.Show("Фигура A > Фигура Б");
            }
            else if(figureA < figureB)
            {
                MessageBox.Show("Фигура A < Фигура Б");
            }
        }

        private void SquareA_CheckedChanged(object sender, EventArgs e)
        {
            var rd = sender as RadioButton;

            if (rd.Name == "SquareA")
            {
                figureA = square;
            }
            else if(rd.Name == "RectangleA")
            {
                figureA = rectangle;
            }
            else if(rd.Name == "CircleA")
            {
                figureA = circle;
            }
            else if (rd.Name == "TriangleA")
            {
                figureA = triangle;
            }
        }

        private void squareB_CheckedChanged(object sender, EventArgs e)
        {
            var rd = sender as RadioButton;

            if (rd.Name == "squareB")
            {
                figureB = square;
            }
            else if (rd.Name == "rectangleB")
            {
                figureB = rectangle;
            }
            else if (rd.Name == "circleB")
            {
                figureB = circle;
            }
            else if (rd.Name == "triangleb")
            {
                figureB = triangle;
            }
        }

        private void xA_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void xContainer_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            currentFigure.Rotate(int.Parse(rotateAngle.Text));
        }

        private void draw_Click(object sender, EventArgs e)
        {

            containerX = float.Parse(xContainer.Text);
            containerY = float.Parse(yContainer.Text);
            containerWidth = float.Parse(widthContainer.Text);
            containerHeight = float.Parse(heightContainer.Text);
            if (drawCircle.Checked == true)
            {
                circle = new Circle(pictureBox1, new RectangleF(containerX, containerY, containerWidth, containerHeight));
                circle.Draw();

                currentFigure = circle;
            }
            else if(drawTriangle.Checked == true)
            {
                triangle = new Triangle(pictureBox1, new RectangleF(containerX, containerY, containerWidth, containerHeight));
                triangle.Draw();


                currentFigure = triangle;
            }
            else if(rectangleDraw.Checked == true)
            {
                rectangle = new Rectangle(pictureBox1, new RectangleF(containerX, containerY, containerWidth, containerHeight));
                rectangle.Draw();

                currentFigure = rectangle;
            }
            else if(drawSquare.Checked == true)
            {
                square = new Square(pictureBox1, new RectangleF(containerX, containerY, containerWidth, containerHeight));
                square.Draw();

                currentFigure = square;
            }
           
        }
    }
}
