using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Lab_1_1
{
    class Rendering
    {
        Graphics graphic;
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);

       // Graphics g = Form1.ActiveForm.CreateGraphics();


        List<int> Points = new List<int>();
        public Rendering(List<int> ListPonts,Graphics graphics) 
        {
            graphic = graphics;

            for ( int i = 0; i < ListPonts.Count; i++)
            {
                Points.Add(ListPonts[i]);
            }
        }

        public void PrintFigure(IDisplay display)
        {
            //Graphics g = Form1.ActiveForm.CreateGraphics();
            display.Make(Points, pen, graphic);
        }
    }

    interface IDisplay
    {
        void Make(List<int>Points, Pen pen, Graphics graphics);
    }

    class DrawLine : IDisplay
    {
        public void Make(List<int> Points, Pen pen, Graphics graphics)
        {
            Point start = new Point(Points[0], Points[1]);
            Point finish = new Point(Points[Points.Count - 2], Points[Points.Count - 1]);
           
            for (int i = 0; i < Points.Count - 2;)
            {
                Point a = new Point(Points[i++], Points[i++]);
                Point b = new Point(Points[i++], Points[i--]);
                graphics.DrawLine(pen, a, b);
            }

            graphics.DrawLine(pen, finish, start);
        }
    }

    class DrawCircle : IDisplay
    {
        public void Make(List<int> Points, Pen pen, Graphics graphics)
        {
            graphics.DrawEllipse(pen, Points[0], Points[1], Points[2] - Points[0], Points[2] - Points[0]);
        }
    }

    class DrawRectangle : IDisplay
    {
        public void Make(List<int> Points, Pen pen, Graphics graphics)
        {
            graphics.DrawRectangle(pen, Points[0], Points[1], Points[2], Points[3]);
        }
    }
}
