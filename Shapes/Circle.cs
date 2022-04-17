using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Circle: Figure
    {
        Graphics graphic;
        public Circle(List<int> ArrayPoints, Graphics graphics)
        {
            graphic = graphics;

            try
            {
                for (int i = 0; i < 4; i++)
                {
                    point.Add(ArrayPoints[i]);
                }
            }
            catch { }
        }

        public override void PrintFigure()
        {
            //graphic.DrawEllipse(pen, point[0], point[1], point[2]-point[0], point[2]-point[0]);
            Rendering rendering = new Rendering(point, graphic);
            rendering.PrintFigure(new DrawCircle());
        }
    }
}
