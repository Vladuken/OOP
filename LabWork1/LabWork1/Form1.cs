using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LabWork1.Figures;

namespace LabWork1
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        public Form1()
        {
            InitializeComponent();
            canvas = canv.CreateGraphics();
        }

        public void ShowFigures()
        {
            Line line = new Line(new Pen(Color.Black, 3), new Point(10, 10), new Point(300, 50));
            line.Draw(canvas);

            Figures.Rectangle rect = new Figures.Rectangle(new Pen(Color.Black, 3), new Point(10, 10), new Point(50, 100));
            rect.Draw(canvas);

            Figures.Circle cirk = new Figures.Circle(new Pen(Color.Red, 3), new Point(50, 20), new Point(600, 100));
            cirk.Draw(canvas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFigures();
        }
    }
}
