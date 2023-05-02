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
            RectangleF rectangleF  
            ) 
            : base(pictureBox, rectangleF)
        {
            a = new Point((int)rectangleF.X, (int)(rectangleF.Y+rectangleF.Height));
            b = new Point((int)(rectangleF.X + rectangleF.Width/2), (int)rectangleF.Y);
            c = new Point((int)(rectangleF.X+ rectangleF.Width), (int)(rectangleF.Y + rectangleF.Height));


            FindDistances(a, b, c, out AB, out BC, out CA);

            width = rectangleF.Width;
            height = rectangleF.Height;

        }

        public void FindDistances(Point A, Point B, Point C, out double AB, out double BC, out double CA)
        {
            AB = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            BC = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            CA = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));

        }


        private double GetTriangleWidth(double baseLine)
        {
            double S = Area();
            return (2.0 * S / baseLine) is double.NaN ? 0 : (2.0 * S / baseLine);
        }
        private double GetTriangleHeight(double baseLine)
        {
            double p = (AB + BC + CA) / 2.0;
            double S = Area();

            return (2.0 * S / CA ) is double.NaN ? 0 : (2.0 * S / CA);
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
