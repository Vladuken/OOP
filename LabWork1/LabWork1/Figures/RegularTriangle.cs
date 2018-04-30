using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabWork1.Figures
{
    class RegularTriangle : Triangle
    {


        public override Point end
        {
            set
            {
                base.end = value;
                Point p1 = new Point(topLeftPoint.X, downRightPoint.Y);
                Point p2 = new Point(topLeftPoint.X + (int)(height * 2 / Math.Sqrt(3) / 2), topLeftPoint.Y);
                Point p3 = new Point(topLeftPoint.X + (int)(height * 2 / Math.Sqrt(3)), downRightPoint.Y);
                points = new Point[3] { p1, p2, p3 };
            }
        }

        public RegularTriangle(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {             
        }

    }
}
