using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Figures
{
    class Rhombus: Rectangle
    {
        Point[] points = new Point[4];

        

        public override Point end
        {
            set
            {
                //left middle point
                this.points[0].X = topLeftPoint.X;
                this.points[0].Y = (topLeftPoint.Y + downRightPoint.Y) / 2;

                //down middle point
                this.points[1].X = (topLeftPoint.X + downRightPoint.X) / 2;
                this.points[1].Y = downRightPoint.Y;

                //right middle point
                this.points[2].X = downRightPoint.X;
                this.points[2].Y = (topLeftPoint.Y + downRightPoint.Y) / 2;

                //up middle point
                this.points[3].X = (topLeftPoint.X + downRightPoint.X) / 2;
                this.points[3].Y = topLeftPoint.Y;
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
