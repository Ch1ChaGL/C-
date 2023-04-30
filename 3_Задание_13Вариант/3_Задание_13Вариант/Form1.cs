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
            circle = new Circle(pictureBox1, new RectangleF(1, 1, 1, 1), 0, 0, 0);
            triangle = new Triangle(pictureBox1, new RectangleF(1, 1, 1, 1), 0, 0, new Point(0,0), new Point(0,0) , new Point(0,0));
            square = new Square(pictureBox1, new RectangleF(1, 1, 1, 1), 0, 0, 0);
            rectangle = new Rectangle(pictureBox1, new RectangleF(1, 1, 1, 1), 0, 0, 0, 0);
        }
        
    
        
        float containerX;
        float containerY;
        float containerWidth;
        float containerHeight;

        Figure figureA;
        Figure figureB;
        
        private void drawCircle_Click(object sender, EventArgs e)
        {
            double _radius = double.Parse(radius.Text);
            double x = double.Parse(xCircle.Text);
            double y = double.Parse(yCircle.Text);

            containerX = float.Parse(xContainer.Text);
            containerY = float.Parse(yContainer.Text);

            containerWidth = float.Parse(widthContainer.Text);
            containerHeight = float.Parse(heightContainer.Text);

            circle = new Circle(pictureBox1, new RectangleF(containerX, containerY, containerWidth, containerHeight), x, y, _radius);
            circle.Draw();
        }
        private void drawTriangle_Click(object sender, EventArgs e)
        {
            int Ax = int.Parse(xA.Text);
            int Ay = int.Parse(yA.Text);

            int Bx = int.Parse(xB.Text);
            int By = int.Parse(yB.Text);

            int Cx = int.Parse(xC.Text);
            int Cy = int.Parse(yC.Text);

            double x = double.Parse(xTriangle.Text);
            double y = double.Parse(yTriangle.Text);

            containerX = float.Parse(xContainer.Text);
            containerY = float.Parse(yContainer.Text);

            containerWidth = float.Parse(widthContainer.Text);
            containerHeight = float.Parse(heightContainer.Text);


            triangle = new Triangle(pictureBox1, new RectangleF(containerX, containerY, containerWidth, containerHeight),
               (int)x, (int)y, new Point(Ax, Ay), new Point(Bx, By), new Point(Cx, Cy));

            triangle.Draw();
        }
        private void drawSquare_Click(object sender, EventArgs e)
        {
            double side = double.Parse(sideSquare.Text);

            double x = double.Parse(xSquare.Text);
            double y = double.Parse(ySquare.Text);



            containerX = float.Parse(xContainer.Text);
            containerY = float.Parse(yContainer.Text);

            containerWidth = float.Parse(widthContainer.Text);
            containerHeight = float.Parse(heightContainer.Text);
            
            square = new Square(pictureBox1, new RectangleF(containerX, containerY, containerWidth, containerHeight), x, y, side);

            square.Draw();
        }
        private void drawRectangle_Click(object sender, EventArgs e)
        {
            double width = double.Parse(widthRectangle.Text);
            double height = double.Parse(heightRectangle.Text);


            double x = double.Parse(xRectangle.Text);
            double y = double.Parse(yRectangle.Text);



            containerX = float.Parse(xContainer.Text);
            containerY = float.Parse(yContainer.Text);

            containerWidth = float.Parse(widthContainer.Text);
            containerHeight = float.Parse(heightContainer.Text);

            rectangle = new Rectangle(pictureBox1, 
                new RectangleF(containerX, containerY, containerWidth, containerHeight), x,y,width, height);

            rectangle.Draw();
        }

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
            if (xContainer.Text != "" && yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "")
            {
                drawCircle.Enabled = radius.Text != "" && yCircle.Text != "" && xCircle.Text != "" && xContainer.Text != "" &&
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";

                drawSquare.Enabled = sideSquare.Text != "" && ySquare.Text != "" && xSquare.Text != "" && xContainer.Text != "" &&
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";

                drawRectangle.Enabled = heightRectangle.Text != "" &&
                widthRectangle.Text != "" &&
                xRectangle.Text != "" &&
                yRectangle.Text != "" &&
                 xContainer.Text != "" &&
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";

                drawTriangle.Enabled =
                xA.Text != "" &&
                yA.Text != "" &&
                xB.Text != "" &&
                yB.Text != "" &&
                xB.Text != "" &&
                yC.Text != "" &&
                xC.Text != "" &&
                xTriangle.Text != "" &&
                yTriangle.Text != "" &&
                xContainer.Text != "" &&
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";
            }
            else
            {
                containerField = false;
                drawCircle.Enabled = false;
                drawRectangle.Enabled = false;
                drawSquare.Enabled = false;
                drawTriangle.Enabled = false;
            }
                
        }

        private void radius_TextChanged(object sender, EventArgs e)
        {
            drawCircle.Enabled = radius.Text != "" && yCircle.Text != "" && xCircle.Text != "" && xContainer.Text != "" && 
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";
        }

        private void sideSquare_TextChanged(object sender, EventArgs e)
        {
            drawSquare.Enabled = sideSquare.Text != "" && ySquare.Text != "" && xSquare.Text != "" && xContainer.Text != "" &&
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";          
        }

        private void heightRectangle_TextChanged(object sender, EventArgs e)
        {
            drawRectangle.Enabled = heightRectangle.Text != "" &&
                widthRectangle.Text != "" &&
                xRectangle.Text != "" &&
                yRectangle.Text != "" &&
                 xContainer.Text != "" &&
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";                 
        }

        private void xA_TextChanged(object sender, EventArgs e)
        {
            drawTriangle.Enabled = 
                xA.Text != "" &&
                yA.Text != "" &&
                xB.Text != "" &&
                yB.Text != "" &&
                xB.Text != "" &&
                yC.Text != "" &&
                xC.Text != "" &&
                xTriangle.Text != "" &&
                yTriangle.Text != "" &&
                xContainer.Text != "" &&
                yContainer.Text != "" && widthContainer.Text != "" && heightContainer.Text != "";            
        }
    }
}
