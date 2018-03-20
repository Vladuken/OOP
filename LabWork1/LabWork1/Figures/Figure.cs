using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class Figure
    {
        public Point begin, end;
        
        public Pen pen = new Pen(Color.Black, 1);
        public Figure(Pen pen, Point begin, Point end)
        {
            this.pen = pen;
            this.begin = begin;
            this.end = end;
        }
        public virtual void Draw(Graphics graphics){}
    }
}
