using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Figure
    {
        public Point begin, end;
        public Point topLeftPoint;
        public Point downRightPoint;
        public int width, height;

        public Pen pen = new Pen(Color.Black, 1);
        public Figure(Pen pen, Point begin, Point end)
        {
            this.pen = pen;
            this.begin = begin;
            this.end = end;

            this.width = Math.Abs(begin.X - end.X);
            this.height = Math.Abs(begin.Y - end.Y);

            //get topleft point to draw figures using graphics
            topLeftPoint.X = Math.Min(begin.X, end.X);
            downRightPoint.X = Math.Max(begin.X, end.X);

            topLeftPoint.Y = Math.Min(begin.Y, end.Y);
            downRightPoint.Y = Math.Max(begin.Y, end.Y);

        }
        public virtual void Draw(Graphics graphics)
        {

        }
    }
}
