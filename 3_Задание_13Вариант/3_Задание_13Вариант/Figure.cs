using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Задание_13Вариант
{
    internal abstract class Figure
    {


        protected double x;
        protected double y;
        protected double width;
        protected double height;
        protected RectangleF rectangleF;
        protected PictureBox pictureBox;

        protected Figure(PictureBox pictureBox, RectangleF rectangleF, double x, double y, double width, double height)
        {
            if (!figureInContainer(rectangleF, x, y, width, height))
            {
                throw new ArgumentException("Figure does not fit inside the container rectangle.");
            }

            this.x = x; 
            this.y = y; 
            this.width = width; 
            this.height = height;
            this.rectangleF = rectangleF;
            this.pictureBox = pictureBox;
        }

        /// <summary>
        /// Отрисовка контэйнера фигуры
        /// </summary>
        public void DrawContainer()
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            graphics.DrawRectangle(pen, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);

        }

        public bool figureInContainer(RectangleF rectangleF, double x, double y, double width, double height)
        {
            RectangleF figureRect = new RectangleF((float)x, (float)y, (float)width, (float)height);
            return rectangleF.Contains(figureRect) && (x + width) <= rectangleF.Right && (y + height) <= rectangleF.Bottom;
        }


        /// <summary>
        /// Отрисовка фигуры на PictureBox в заданной области
        /// </summary>
        /// <param name="pictureBox">Место вывода - PictureBox</param>
        /// <param name="rectangleF">Область вывода - RectangleF</param>
        public abstract void Draw();

        /// <summary>
        /// Перемещение фигуры
        /// </summary>
        /// <param name="dx">Перемещение по x</param>
        /// <param name="dy">Перемещение по y</param>
        public void Move(int dx, int dy)
        {
            if (!figureInContainer(rectangleF, x + dx, y + dy, width, height)) { MessageBox.Show("Фигура вышла за границы контейнера"); return; }
            x += dx;
            y += dy;
            pictureBox.Refresh();
            DrawContainer();
            Draw();
        }


        /// <summary>
        /// Поворот фигуры на заданый угол
        /// </summary>
        /// <param name="angle">угол</param>
        public abstract void Rotate(double angle);



        /// <summary>
        /// Получение площади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();



        //Перегрузка методов сравнения
        public static bool operator > (Figure a, Figure b)
        {
            return a.Area() > b.Area();
        }
        public static bool operator < (Figure a, Figure b)
        {
            return a.Area() < b.Area();
        }
        public static bool operator >=(Figure a, Figure b)
        {
            return a.Area() >= b.Area();
        }
        public static bool operator <=(Figure a, Figure b)
        {
            return a.Area() <= b.Area();
        }
    }
}
