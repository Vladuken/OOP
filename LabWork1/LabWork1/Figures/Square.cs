using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Square:Rectangle
    {
        public Square(Pen pen,Point begin, Point end):base(pen,begin,end)
        {

        }

        public override void Draw(Graphics graphics)
        {
            if (width >= height)
            {
                graphics.DrawRectangle(pen, topLeftPoint.X, topLeftPoint.Y, width, width);
            }
            else
            {
                graphics.DrawRectangle(pen, topLeftPoint.X, topLeftPoint.Y, height, height);
            }
            
        }
    }
}
