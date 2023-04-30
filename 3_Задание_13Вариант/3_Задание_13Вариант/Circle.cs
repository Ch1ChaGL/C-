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
    internal class Circle : Figure
    {
        double _radius;
        public Circle(
            PictureBox pictureBox,
            RectangleF rectangleF,
            double x, 
            double y,  
            double radius
            ) 
            : base(pictureBox,rectangleF,x,y)
        {

            _radius = radius;
            width = radius * 2;
            height = radius * 2;
            if (!figureInContainer(rectangleF, this.x, this.y, width, height))
            {
                throw new ArgumentException("Figure does not fit inside the container rectangle.");
            }

        }

        public override double Area()
        {
            return Math.PI * (_radius * _radius);
        }

        public override void Draw()
        {
            base.Draw();
            //// Получаем объект Graphics из PictureBox
            Graphics graphics = pictureBox.CreateGraphics();

            //// Рисуем круг
            //Pen pen = new Pen(Color.Black);

            //graphics.DrawEllipse(pen,(float)x,(float)y,(float)_radius * 2, (float)_radius * 2);

            //SolidBrush brush = new SolidBrush(Color.Red);
            //// Рисуем закрашенную половину круга
            //graphics.FillPie(brush, (float)x, (float)y, (float)_radius * 2, (float)_radius * 2, 0, 180);




            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Blue);

            // вычисляем координаты центра круга
            int centerX = (int)(x + _radius);
            int centerY = (int)(y + _radius);

            // создаем матрицу поворота вокруг центра круга
            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt((float)angle, new PointF(centerX, centerY));

            // применяем матрицу трансформации для Graphics объекта
            graphics.Transform = transformMatrix;

            // рисуем закрашенную половину круга
            graphics.FillPie(brush, (float)x, (float)y, (float)_radius * 2, (float)_radius * 2, 270, 180);

            // рисуем оставшуюся часть круга
            graphics.DrawEllipse(pen, (float)x, (float)y, (float)_radius * 2, (float)_radius * 2);

        }

    }
}
