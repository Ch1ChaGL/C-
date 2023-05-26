using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Задание_16Вариант
{
    public class Triangle
    {

        PictureBox container;
        Point[] points;
        public Triangle()
        {
            points = new Point[] { new Point(0,0), new Point(0,0), new Point(0,0)};
        }
        public Triangle(PictureBox container, Point A, Point B, Point C) 
        {
            this.container = container;
            points = new Point[] { A, B, C };
            if (!ArePointsInsidePictureBox(container, points)) { throw new Exception("Не все точки находятся внутри контейнера"); }
        }
        public Triangle(PictureBox container ,string input)
        {
            // Находим индексы начала и конца координат точки A
            int startIndexA = input.IndexOf("Точка А") + 11;
            int endIndexA = input.IndexOf(")", startIndexA);

            // Извлекаем строку с координатами точки A
            string pointAStr = input.Substring(startIndexA, endIndexA - startIndexA);

            // Разделяем строку координат точки A по символу ";"
            string[] pointACoords = pointAStr.Split(';');

            // Извлекаем значения координат точки A
            int pointAX = int.Parse(pointACoords[0]);
            int pointAY = int.Parse(pointACoords[1]);

            // Находим индексы начала и конца координат точки B
            int startIndexB = input.IndexOf("Точка B") + 11;
            int endIndexB = input.IndexOf(")", startIndexB);

            // Извлекаем строку с координатами точки B
            string pointBStr = input.Substring(startIndexB, endIndexB - startIndexB);

            // Разделяем строку координат точки B по символу ";"
            string[] pointBCoords = pointBStr.Split(';');

            // Извлекаем значения координат точки B
            int pointBX = int.Parse(pointBCoords[0]);
            int pointBY = int.Parse(pointBCoords[1]);

            // Находим индексы начала и конца координат точки C
            int startIndexC = input.IndexOf("Точка C") + 11;
            int endIndexC = input.IndexOf(")", startIndexC);

            // Извлекаем строку с координатами точки C
            string pointCStr = input.Substring(startIndexC, endIndexC - startIndexC);

            // Разделяем строку координат точки C по символу ";"
            string[] pointCCoords = pointCStr.Split(';');

            // Извлекаем значения координат точки C
            int pointCX = int.Parse(pointCCoords[0]);
            int pointCY = int.Parse(pointCCoords[1]);

            this.container = container;
            points = new Point[] { new Point(pointAX, pointAY), new Point(pointBX, pointBY), new Point(pointCX, pointCY) };

            if (!ArePointsInsidePictureBox(container, points)) { throw new Exception("Не все точки находятся внутри контейнера"); }
        }
        public void Draw()
        {
            if (container != null && points.Length == 3)
            {
                using (Graphics graphics = container.CreateGraphics())
                {
                    graphics.Clear(Color.White);
                    graphics.DrawPolygon(Pens.Red, points);
                }
            }
        }

        public bool ArePointsInsidePictureBox(PictureBox pictureBox, params Point[] points)
        {
            if (pictureBox == null || points.Length == 0)
            {
                return false;
            }

            Rectangle pictureBoxBounds = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);

            foreach (Point point in points)
            {
                if (!pictureBoxBounds.Contains(point))
                {
                    return false;
                }
            }

            return true;
        }

        static public explicit operator double(Triangle ob)
        {
            if (ob.points.Length != 3)
            {
                throw new Exception("Проблема");
            }

            double a = CalculateDistance(ob.points[0], ob.points[1]);
            double b = CalculateDistance(ob.points[1], ob.points[2]);
            double c = CalculateDistance(ob.points[2], ob.points[0]);

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
        static private double CalculateDistance(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }


        /// <summary>
        /// Смещение на заданное расстояние
        /// </summary>
        /// <param name="distance">Расстояние</param>
        /// <param name="direction">Направление 1-вертикаль, 2-горизонталь</param>
        public void moveTriangle(int distance, int direction)
        {
            //Вертикаль
            if(direction == 1)
            {
                for(int i = 0; i<points.Length; i++)
                {
                    points[i].Y += distance;
                }
                if (!ArePointsInsidePictureBox(container, points)) 
                {

                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i].Y -= distance;
                    }
                    throw new Exception("Не все точки находятся внутри контейнера");
                }
                Draw();
            }
            //Горизонталь
            if (direction == 2)
            {
                for (int i = 0; i < points.Length; i++)
                {
                    points[i].X += distance;
                }
                if (!ArePointsInsidePictureBox(container, points)) 
                {
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i].X -= distance;
                    }
                    throw new Exception("Не все точки находятся внутри контейнера"); 
                }
                Draw();
            }

        }

        public static bool operator >(Triangle ob1, Triangle ob2)
        {
            return (double)ob1 > (double)ob2;
        }

        public static bool operator <(Triangle ob1, Triangle ob2)
        {
            return (double)ob1 < (double)ob2;
        }

        public static bool operator >=(Triangle ob1, Triangle ob2)
        {
            return (double)ob1 >= (double)ob2;
        }

        public static bool operator <=(Triangle ob1, Triangle ob2)
        {
            return (double)ob1 <= (double)ob2;
        }

        public static bool operator !=(Triangle ob1, Triangle ob2)
        {
            return (double)ob1 != (double)ob2;
        }

        public static bool operator ==(Triangle ob1, Triangle ob2)
        {
            return (double)ob1 == (double)ob2;
        }
        public bool IsPointInsideTriangle(Point P)
        {
            double areaABC = CalculateTriangleArea(points[0], points[1], points[2]);
            double areaPAB = CalculateTriangleArea(P, points[0], points[1]);
            double areaPBC = CalculateTriangleArea(P, points[1], points[2]);
            double areaPCA = CalculateTriangleArea(P, points[2], points[0]);

            // Если сумма площадей треугольников PAB, PBC и PCA равна площади треугольника ABC,
            // то точка P лежит внутри треугольника ABC
            return Math.Abs(areaABC - (areaPAB + areaPBC + areaPCA)) < 0.000001;
        }

        private double CalculateTriangleArea(Point A, Point B, Point C)
        {
            return Math.Abs(0.5 * ((A.X - C.X) * (B.Y - A.Y) - (A.Y - C.Y) * (B.X - A.X)));
        }
        public override string ToString()
        {
            return $"Точка А = ({points[0].X};{points[0].Y}), Точка B = ({points[1].X};{points[1].Y}), Точка C = ({points[2].X};{points[2].Y})";
        }
    }
}
