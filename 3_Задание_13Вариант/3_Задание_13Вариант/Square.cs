﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Задание_13Вариант
{
    internal class Square : Rectangle
    {
        public Square(
            PictureBox pictureBox,
            RectangleF rectangleF
            ) :
            base(pictureBox, rectangleF) { }     
    }
}
