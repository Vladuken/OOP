using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Figures
{
    class Rhombus: Polygons
    {

        
        public override Point end
        {
            set
            {
                base.end = value;
                Point p1 = new Point(topLeftPoint.X, (topLeftPoint.Y + downRightPoint.Y) / 2);
                Point p2 = new Point((topLeftPoint.X + downRightPoint.X) / 2, downRightPoint.Y);
                Point p3 = new Point(downRightPoint.X, (topLeftPoint.Y + downRightPoint.Y) / 2);
                Point p4 = new Point((topLeftPoint.X + downRightPoint.X) / 2, topLeftPoint.Y);
                points = new Point[4] {p1,p2,p3,p4};
            }
        }

        public override Point begin
        {
            set
            {
                base.begin = value;
            }
        }



        public Rhombus(Pen pen, Point begin , Point end):base(pen,begin,end)
        {
            
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen,points);
        }
    }
}
