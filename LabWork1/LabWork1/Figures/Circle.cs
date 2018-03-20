﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Figures
{
    class Circle:Ellipse
    {
        public Circle(Pen pen,Point begin, Point end):base(pen,begin,end)
        {

        }
        public override void Draw(Graphics graphics)
        {
            if (width >= height)
            {
                graphics.DrawEllipse(pen, topLeftPoint.X, topLeftPoint.Y, width, width);
            }
            else
            {
                graphics.DrawEllipse(pen, topLeftPoint.X, topLeftPoint.Y, height, height);
            }
        }
    }
}