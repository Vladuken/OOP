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

            if (begin.X <= end.X)
            {
                this.topLeftPoint.X = begin.X;
                this.downRightPoint.X = end.X;
            }
            else
            {
                this.topLeftPoint.X = end.X;
                this.downRightPoint.X = begin.X;
            }

            if (begin.Y <= end.Y)
            {
                this.topLeftPoint.Y = begin.Y;
                this.downRightPoint.Y = end.Y;
            }
            else
            {
                this.topLeftPoint.Y = end.Y;
                this.downRightPoint.Y = begin.Y;
            }

        }
        public virtual void Draw(Graphics graphics)
        {

        }
    }
}
