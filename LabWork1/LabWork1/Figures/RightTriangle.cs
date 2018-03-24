using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabWork1.Figures
{
    class RightTriangle : Triangle
    {

   
        public RightTriangle(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {

            //up middle point
            this.points[1].X = topLeftPoint.X;
            this.points[1].Y = topLeftPoint.Y;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }

    }
}
