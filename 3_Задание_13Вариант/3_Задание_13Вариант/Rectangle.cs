using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _3_Задание_13Вариант
{
    internal class Rectangle : Figure
    {
        public Rectangle(
            PictureBox pictureBox,
            RectangleF rectangleF
            )
            : base(pictureBox, rectangleF)
        {


        }

        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            base.Draw();
            //DrawContainer();
            Graphics graphics = pictureBox.CreateGraphics();

            // вычисляем координаты центра фигуры
            double centerX = rectangleF.X + rectangleF.Width / 2.0;
            double centerY = rectangleF.Y + rectangleF.Height / 2.0;

            // создаем матрицу поворота вокруг центра фигуры
            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt((float)angle, new PointF((float)centerX, (float)centerY));

            // применяем матрицу трансформации для Graphics объекта
            graphics.Transform = transformMatrix;

            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, (float)rectangleF.X, (float)rectangleF.Y, (float)rectangleF.Width, (float)rectangleF.Height);
        }

    }
}