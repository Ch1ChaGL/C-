using System;
using System.Collections.Generic;
using System.Drawing;
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
            double width, 
            double height, 
            double radius
            ) 
            : base(pictureBox,rectangleF,x,y,width,height)
        {
            _radius = radius;
            this.width = radius * 2;
            this.height = radius * 2;

            // Вычисляем координаты круга
            this.x = rectangleF.X + rectangleF.Width / 2 - (float)_radius;
            this.y = rectangleF.Y + rectangleF.Height / 2 - (float)_radius;
        }

































        public override double Area()
        {
            return Math.PI * (_radius * _radius);
        }

        public override void Draw()
        {
            DrawContainer();
            // Получаем объект Graphics из PictureBox
            Graphics graphics = pictureBox.CreateGraphics();

            // Рисуем круг
            Pen pen = new Pen(Color.Black);
            graphics.DrawEllipse(pen,(float)x,(float)y,(float)_radius * 2, (float)_radius * 2);
        }     

        public override void Rotate(double angle)
        {
            throw new NotImplementedException();
        }
    }
}
