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

        public RegularTriangle(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {
        
            //left down point
            this.points[0].X = topLeftPoint.X;
            this.points[0].Y = (downRightPoint.Y);

            //up middle point
            this.points[1].X = topLeftPoint.X + (int)(height * 2 / Math.Sqrt(3) / 2);
            this.points[1].Y = topLeftPoint.Y;

            //right down point
            this.points[2].X = topLeftPoint.X + (int)(height * 2 / Math.Sqrt(3));
            this.points[2].Y = downRightPoint.Y;
            
        }

    }
}
