using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab_1_1
{
    public partial class Form1 : Form
    {
        Graphics graphic;
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
        List<Figure> list = new List<Figure>();
        List<int> points = new List<int>();
        public Form1()
        {
            InitializeComponent();
            graphic = CreateGraphics();
        }

        private int[] GetPoint(int lengthArray, List<int> list)
        {
            int[] pointXY = new int[lengthArray];

            for (int i = 0; i < lengthArray; i++)
            {
                pointXY[i] = list[i];
                list[i] = 0;  
            }

            return pointXY;
        }

        private void ClearList(List<int> list)
        {
            int length = list.Count;
            for (int i = 0; i < length; i++)
            {
                list.Remove(0);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(GetPoint(6,points));
            triangle.PrintFigure(pen, graphic);
            ClearList(points);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Segment segment = new Segment(GetPoint(4, points));
            segment.PrintFigure(pen, graphic);
            ClearList(points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(GetPoint(4, points));
            circle.PrintFigure(pen, graphic);
            ClearList(points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(GetPoint(4, points));
            rectangle.PrintFigure(pen, graphic);
            ClearList(points);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trapezium trapezium = new Trapezium(GetPoint(8, points));
            trapezium.PrintFigure(pen, graphic);
            ClearList(points);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hexagon hexagon = new Hexagon(GetPoint(12, points));
            hexagon.PrintFigure(pen, graphic);
            ClearList(points);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.X);
            points.Add(e.Y);
        }
    }
}
