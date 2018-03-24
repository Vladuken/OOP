using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Ellipse : Rectangle
    {
        //public Point topLeftPoint;
        //public Point downRightPoint;

        //public int width, height;

        public Ellipse(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {
            //this.width = Math.Abs(begin.X - end.X);
            //this.height = Math.Abs(begin.Y - end.Y);

            //get topleft point to draw figures using graphics
            //this.topLeftPoint.X = Math.Min(begin.X, end.X);
            //this.downRightPoint.X = Math.Max(begin.X, end.X);

            //this.topLeftPoint.Y = Math.Min(begin.Y, end.Y);
            //this.downRightPoint.Y = Math.Max(begin.Y, end.Y);
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeftPoint.X, topLeftPoint.Y, width, height);
        }
    }
}
