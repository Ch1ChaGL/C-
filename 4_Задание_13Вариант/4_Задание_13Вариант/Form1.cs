using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4_Задание_13Вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sec = 0;
        int width = 100, height = 60;
        int x = 1, y = 100;
        int dx = 5;
        Rectangle rect; //прямоугольная область, в которой находиться фигура
        Form2 f = new Form2();
        public Color Color1
        {
            get
            {
                return brushColor1.Color;
            }
            set
            {
                brushColor1.Color = value;
            }
        }
        public Color Color2 
        {
            get
            {
                return brushColor2.Color;
            }
            set
            {
                brushColor2.Color = value;
            }
        }
        public Direction MyDirection
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }
        public int Speed 
        {
            get
            {
                return timer1.Interval;
            }
            set
            {
                timer1.Interval = value;
            }
        }
        public enum Direction 
        { 
            Left, 
            Right, 
            Up, 
            Down 
        };

        Direction direction; //флаг изменения направления движения

        //кисти используемые для для закраски прямоугольника
        SolidBrush brush = new SolidBrush(Color.Red);
        SolidBrush brushColor1 = new SolidBrush(Color.Red);
        SolidBrush brushColor2= new SolidBrush(Color.Black);

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (f != null)
            {
                f.Dispose();
                f = new Form2();
                f.Owner = this;
            }
            f.Show();  // отображаем Form2
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush, rect);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;  // секунды
            rect = new Rectangle(x, y, width, height); // размер прямоугольной области
            Invalidate(rect, true);      // вызываем прорисовку области   
            int TEMP = width;
            if (direction == Direction.Left || direction == Direction.Right)
            {
                if (direction == Direction.Left) // движение влево
                { 
                    x -= dx;
                    
                    brush = brushColor1;
                }
                if (direction == Direction.Right) 
                {
                    x += dx;
                    brush = brushColor2; // движение вправо
                }
               

                if (x >= ClientSize.Width - width) // если достигли правого края формы
                {

                    direction = Direction.Left; // меняем статус движения на левый
                    width = height;
                    height = TEMP;
                    brush = brushColor1.Color == brush.Color ? brushColor2 : brushColor1;
                }
                else
                if (x <= 1) // если достигли левого края формы
                {
                    direction = Direction.Right;    // меняем статус движения на правый
                    width = height;
                    height = TEMP;
                    brush = brushColor2.Color == brush.Color ? brushColor1 : brushColor2;
                }
            }
            else
            {
                if (direction == Direction.Up)
                    y -= dx;
                if (direction == Direction.Down)
                    y += dx;

                if (y <= 1)
                {
                    direction = Direction.Down;
                    width = height;
                    height = TEMP;
                    brush = brushColor1;
                }
                else
                if (y >= ClientSize.Height - width)
                {
                    direction = Direction.Up;
                    width = height;
                    height = TEMP;
                    brush = brushColor2;
                }
            }
            rect = new Rectangle(x, y, width, height); // новая прямоугольная область
            Invalidate(rect, true);  // вызываем прорисовку этой области
        }
    }
}
