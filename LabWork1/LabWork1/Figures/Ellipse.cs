using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Ellipse : Figure
    {
        public Ellipse(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeftPoint.X, topLeftPoint.Y, width, height);
        }
    }
}
