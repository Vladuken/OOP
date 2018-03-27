using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class FigureList
    {
        private List<Figure> figureList;

        public FigureList()
        {
            this.figureList = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            this.figureList.Add(figure);
        }

        public void AddFirst(Figure figure)
        {
            this.figureList.Insert(0,figure);
        }

        public void RemoveLast()
        {
            this.figureList.RemoveAt(figureList.Count() - 1);
        }
        public int Count()
        {
            return figureList.Count();
        }
        public void Clear()
        {
            this.figureList.Clear();
        }

        

        public void Draw(Graphics graphics)
        {
            foreach (Figure figure in figureList)
            {
                figure.Draw(graphics);
            }
        }
        
    }
}
