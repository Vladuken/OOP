using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Triangle: Polygons
    {


        public override Point end
        {
            set
            {
                base.end = value;
                Point p1 = new Point(topLeftPoint.X, downRightPoint.Y);
                Point p2 = new Point((topLeftPoint.X + downRightPoint.X) / 2, topLeftPoint.Y);
                Point p3 = new Point(downRightPoint.X, downRightPoint.Y);
                points = new Point[3] { p1, p2, p3 };
            }
        }


        public Triangle(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
