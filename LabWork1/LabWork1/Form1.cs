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
        Figure figBuff = new Figure(new Pen(Color.White),new Point(), new Point());
        
        FigureList figureList = new FigureList();

        Dictionary<int, Figure> figureDict = new Dictionary<int, Figure>();

        Color color = Color.Black;
        int figureTag = 1;

        public Form1()
        {
            InitializeComponent();
            canvas = canv.CreateGraphics();
            InitialiseDict();
        }

        private void InitialiseDict()
        {
            figureDict.Add(1, new Figures.Rectangle(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(2, new Square(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(3, new Ellipse(new Pen(color, 3),startpoint, endpoint));
            figureDict.Add(4, new Circle(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(5, new Line(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(6, new Rhombus(new Pen(color, 3),startpoint, endpoint));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Line line = new Line(new Pen(Color.Black, 3), startpoint, endpoint);
            line.Draw(canvas);
            figureList.Add(line);

            Figures.Rectangle rect = new Figures.Rectangle(new Pen(Color.Black, 3),new Point(10,20), new Point(300, 300));
            rect.Draw(canvas);
            figureList.Add(rect);

            Figures.Ellipse cirk = new Figures.Ellipse(new Pen(Color.Black, 3), new Point(100, 100), new Point(200, 400));
            cirk.Draw(canvas);
            figureList.Add(cirk);

            Figures.Square square = new Figures.Square(new Pen(Color.Black, 3), new Point(0, 50), new Point(100, 600));
            square.Draw(canvas);
            figureList.Add(square);

            Figures.Circle circle = new Figures.Circle(new Pen(Color.Black, 3), new Point(600, 100), new Point(250, 300));
            circle.Draw(canvas);
            figureList.Add(circle);

        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            if (figureList.Count() > 0)
            {
                figureList.RemoveLast();
                canvas.Clear(Color.White);
                figureList.Draw(canvas);
            }
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            figureTag = 1;
        }

        

        private void Square_Click(object sender, EventArgs e)
        {
            figureTag = 2;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            figureTag = 3;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            figureTag = 4;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            figureTag = 5;
        }

        private void Rhombus_Click(object sender, EventArgs e)
        {
            figureTag = 6;
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

            XLable.Text = "X = " + e.X.ToString();
            YLable.Text = "Y = " + e.Y.ToString();
        }

        private void choseColor_Click(object sender, EventArgs e)
        {
            DialogResult result = ChooseColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = ChooseColor.Color;
                choseColor.BackColor = ChooseColor.Color;
            }
        }

        private void canv_MouseUp(object sender, MouseEventArgs e)
        {
            endpoint.X = e.X;
            endpoint.Y = e.Y;

            figureDict.Clear();
            InitialiseDict();

            figBuff = figureDict[figureTag];
            figureList.Add(figBuff);
            figureList.Draw(canvas);
        }
    }
}
