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
        Color color = Color.Black;
        Pen pen = new Pen(Color.Black, 3);
        Figure figBuff;
        FigureList figureList = new FigureList();

        //Dictionary<int, Figure> figureDict = new Dictionary<int, Figure>();

        //int figureTag = 1;

        private bool isDrawn = false;

        public Form1()
        {
            InitializeComponent();
            canvas = canv.CreateGraphics();
            figBuff = new Figures.Rectangle(new Pen(color, 3), startpoint, endpoint);
            //InitialiseDict();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            FigureList lablist = new FigureList();
            lablist.Add(new Line(new Pen(color, 3), new Point(50,50),new Point(50,200)));
            lablist.Add(new Figures.Rectangle(new Pen(color, 3), new Point(60, 50), new Point(150, 200)));
            lablist.Add(new Figures.Ellipse(new Pen(color, 3), new Point(170, 50), new Point(300, 200)));
            lablist.Add(new Figures.Square(new Pen(color, 3), new Point(310, 50), new Point(400, 200)));
            lablist.Add(new Figures.Circle(new Pen(color, 3), new Point(500, 50), new Point(600, 200)));
            lablist.Add(new Figures.Rhombus(new Pen(color, 3), new Point(60, 300), new Point(150, 450)));
            lablist.Add(new Figures.Triangle(new Pen(color, 3), new Point(170, 300), new Point(280, 450)));
            lablist.Add(new Figures.RightTriangle(new Pen(color, 3), new Point(320, 300), new Point(400, 450)));
            lablist.Add(new Figures.RegularTriangle(new Pen(color, 3), new Point(450, 300), new Point(600, 450)));
            lablist.Draw(canvas);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);

            if (figureList.Count() > 0)
            {
                figureList.RemoveLast();
                figureList.Draw(canvas);
            }
        }


        /*private void InitialiseDict()
        {
            figureDict.Add(1, new Figures.Rectangle(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(2, new Square(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(3, new Ellipse(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(4, new Circle(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(5, new Line(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(6, new Rhombus(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(7, new Triangle(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(8, new RightTriangle(new Pen(color, 3), startpoint, endpoint));
            figureDict.Add(9, new RegularTriangle(new Pen(color, 3), startpoint, endpoint));
        }*/


        private void Rectangle_Click(object sender, EventArgs e)
        {
            figBuff = new Figures.Rectangle(new Pen(color, 3), startpoint, endpoint);
        }
        private void Square_Click(object sender, EventArgs e)
        {
            figBuff = new Square(new Pen(color, 3), startpoint, endpoint);
        }
        private void Ellipse_Click(object sender, EventArgs e)
        {
            figBuff = new Ellipse(new Pen(color, 3), startpoint, endpoint);
        }
        private void Circle_Click(object sender, EventArgs e)
        {
            figBuff = new Circle(new Pen(color, 3), startpoint, endpoint);
        }
        private void Line_Click(object sender, EventArgs e)
        {
            figBuff = new Line(new Pen(color, 3), startpoint, endpoint);
        }
        private void Rhombus_Click(object sender, EventArgs e)
        {
            figBuff = new Rhombus(new Pen(color, 3), startpoint, endpoint);
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            figBuff = new Triangle(new Pen(color, 3), startpoint, endpoint);
        }
        private void RightTriangle_Click(object sender, EventArgs e)
        {
            figBuff = new RightTriangle(new Pen(color, 3), startpoint, endpoint);
        }
        private void RegularTriangle_Click(object sender, EventArgs e)
        {
            figBuff = new RegularTriangle(new Pen(color, 3), startpoint, endpoint);
        }

        private void canv_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawn = true;

            startpoint.X = e.X;
            startpoint.Y = e.Y;
            figBuff.begin = startpoint;
            figBuff.end = startpoint;
        }

        private void canv_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawn)
            {
                endpoint.X = e.X;
                endpoint.Y = e.Y;
                //figureDict.Clear();
                //InitialiseDict();
                //figBuff = figureDict[figureTag];
                figBuff.end = endpoint;
                canv.Refresh();
            }

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

        private void canv_Paint(object sender, PaintEventArgs e)
        {
            figureList.Draw(e.Graphics);
            if (isDrawn)
            {
                figBuff.Draw(e.Graphics);
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            figureList.Clear();
            canvas.Clear(Color.White);
        }

        private void canv_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawn = false;
            endpoint.X = e.X;
            endpoint.Y = e.Y;

            //figureDict.Clear();
            //InitialiseDict();
            //figBuff = figureDict[figureTag];
            figBuff.end = endpoint;

            figureList.Add(figBuff);

            figBuff = (Figure)Activator.CreateInstance(figBuff.GetType(), pen,startpoint,endpoint);
            figureList.Draw(canvas);
        }
    }
}
