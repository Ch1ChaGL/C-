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
    internal class Rectangle : Figure
    {
        public Rectangle(
            PictureBox pictureBox,
            RectangleF rectangleF,
            double x,
            double y,
            double width,
            double height
            )
            : base(pictureBox, rectangleF, x, y)
        {
            this.width = width;
            this.height = height;
            if (!figureInContainer(rectangleF, this.x, this.y, width, height))
            {
                throw new ArgumentException("Figure does not fit inside the container rectangle.");
            }
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            base.Draw();
            DrawContainer();
            Graphics graphics = pictureBox.CreateGraphics();

            // вычисляем координаты центра фигуры
            double centerX = x + width / 2.0;
            double centerY = y + height / 2.0;

            // создаем матрицу поворота вокруг центра фигуры
            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt((float)angle, new PointF((float)centerX, (float)centerY));

            // применяем матрицу трансформации для Graphics объекта
            graphics.Transform = transformMatrix;

            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, (float)x, (float)y, (float)width, (float)height);
        }

    }
}