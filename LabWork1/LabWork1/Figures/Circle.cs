using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Circle : Figure
    {
        public Circle(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {
            this.pen = pen;
            this.begin = begin;
            this.end = end;
        }
        public override void Draw(Graphics graphics)
        {
            int width = Math.Abs(begin.X - end.X);
            int height = Math.Abs(begin.Y - end.Y);
            graphics.DrawEllipse(pen, begin.X,begin.Y,width,height);
        }
    }
}
