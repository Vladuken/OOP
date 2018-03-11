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
        Point startpoint, endpoint;
        Graphics canvas;
        Pen pen = new Pen(Color.Black, 3);
        

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

            Figures.Ellipse cirk = new Figures.Ellipse(new Pen(Color.Red, 3), new Point(50,50), new Point(600, 100));
            cirk.Draw(canvas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFigures();
        }

        private void canv_MouseDown(object sender, MouseEventArgs e)
        {
            startpoint.X = e.X;
            startpoint.Y = e.Y;
        }

        private void canv_MouseMove(object sender, MouseEventArgs e)
        {
            //Point buff = new Point(e.X, e.Y);
            //Figures.Rectangle rect = new Figures.Rectangle(pen, startpoint, buff);
            //rect.Draw(canvas);
            //pen.Color = Color.White;
            //rect.Draw(canvas);
            //pen.Color = Color.Black;

        }

        private void canv_MouseUp(object sender, MouseEventArgs e)
        {
            endpoint.X = e.X;
            endpoint.Y = e.Y;

            //Line line = new Line(new Pen(Color.Black, 3), startpoint, endpoint);
            //line.Draw(canvas);

            //Figures.Rectangle rect = new Figures.Rectangle(new Pen(Color.Black, 3),startpoint, endpoint);
            //rect.Draw(canvas);

            //Figures.Ellipse cirk = new Figures.Ellipse(new Pen(Color.Black, 3), startpoint, endpoint);
            //cirk.Draw(canvas);

            //Figures.Square square = new Figures.Square(new Pen(Color.Black, 3), startpoint, endpoint);
            //square.Draw(canvas);

            //Figures.Circle circle = new Figures.Circle(new Pen(Color.Black, 3), startpoint, endpoint);
            //circle.Draw(canvas);

            Figures.Rhombus romb = new Figures.Rhombus(new Pen(Color.Black, 3), startpoint, endpoint);
            romb.Draw(canvas);

        }
    }
}
