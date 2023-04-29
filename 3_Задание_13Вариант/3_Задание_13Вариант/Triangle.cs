using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Задание_13Вариант
{
    internal class Triangle : Figure
    {
        Point a;
        Point b;
        Point c;
        double AB;
        double BC;
        double CA;
        public Triangle(
            PictureBox pictureBox, 
            RectangleF rectangleF, 
            int x, 
            int y, 
            Point a, 
            Point b,
            Point c
            ) 
            : base(pictureBox, rectangleF, x, y)
        {
            this.a = new Point(a.X + x, a.Y +y);
            this.b = new Point(b.X + x, b.Y + y);
            this.c = new Point(c.X + x, c.Y + y);


            FindDistances(a, b, c, out AB, out BC, out CA);

            width = GetTriangleWidth(BC);
            height = GetTriangleHeight(BC);


            if (!figureInContainer(rectangleF, x, y, width, height))
            {
                throw new ArgumentException("Figure does not fit inside the container rectangle.");
            }
        }

        public void FindDistances(Point A, Point B, Point C, out double AB, out double BC, out double CA)
        {
            AB = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            BC = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            CA = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            
            if (AB + BC <= CA || AB + CA <= BC || BC + CA <= AB)
            {
                throw new ArgumentException("Triangle with such sides does not exist.");
            }
        }


        private double GetTriangleWidth(double baseLine)
        {
            double S = Area();
            return 2.0 * S / baseLine;
        }
        private double GetTriangleHeight(double baseLine)
        {
            double p = (AB + BC + CA) / 2.0;
            double S = Area();

            return 2.0 * S / CA;
        }

        public override void Draw()
        {
            base.Draw();
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black);


            // Найти центр треугольника
            double centerX = (a.X + b.X + c.X) / 3.0;
            double centerY = (a.Y + b.Y + c.Y) / 3.0;

            // Создать матрицу поворота вокруг центра треугольника
            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt((float)angle, new PointF((float)centerX, (float)centerY));

            // применяем матрицу трансформации для Graphics объекта
            graphics.Transform = transformMatrix;

            graphics.DrawPolygon(pen, new Point[] { a, b, c });
        }
        public override double Area()
        {
            // Вычисляем длины сторон треугольника
            

            // Вычисляем полупериметр треугольника
            double s = (AB + BC + CA) / 2.0;

            return Math.Sqrt(s * (s - AB) * (s - BC) * (s - CA));
        }
    }
}
