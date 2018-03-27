using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    abstract class Figure
    {
        public virtual Point begin { get; set; }
        public virtual Point end { get; set; }
        
        public Pen pen = new Pen(Color.Black, 1);
        public Figure(Pen pen, Point begin, Point end)
        {
            this.pen = pen;
            this.begin = begin;
            this.end = end;
        }
        public abstract void Draw(Graphics graphics);
    }
}
