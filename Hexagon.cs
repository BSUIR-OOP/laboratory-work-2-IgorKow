using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Hexagon: Figure
    {
        public Hexagon(int[] ArrayPoints)
        {
            for(int i = 0; i < 12; i++)
            {
                point.Add(ArrayPoints[i]);
            }

        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(point[0], point[1]);
            Point b = new Point(point[2], point[3]);
            Point c = new Point(point[4], point[5]);
            Point d = new Point(point[6], point[7]);
            Point e = new Point(point[8], point[9]);
            Point f = new Point(point[10], point[11]);

            graphic.DrawLine(pen, a, b);
            graphic.DrawLine(pen, b, c);
            graphic.DrawLine(pen, c, d);
            graphic.DrawLine(pen, d, e);
            graphic.DrawLine(pen, e, f);
            graphic.DrawLine(pen, f, a);
        }
    }
}
