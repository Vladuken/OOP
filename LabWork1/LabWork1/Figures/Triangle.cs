using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Triangle: Rectangle
    {

        public Point[] points = new Point[3];

        public Triangle(Pen pen, Point begin, Point end) : base(pen, begin, end)
        {
            //left down point
            this.points[0].X = topLeftPoint.X;
            this.points[0].Y = (downRightPoint.Y);
            //this.points[0].Y = (topLeftPoint.Y - downRightPoint.Y);

            //up middle point
            this.points[1].X = (topLeftPoint.X + downRightPoint.X) / 2;
            this.points[1].Y = topLeftPoint.Y;

            //right down point
            this.points[2].X = downRightPoint.X;
            this.points[2].Y = downRightPoint.Y;

        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
