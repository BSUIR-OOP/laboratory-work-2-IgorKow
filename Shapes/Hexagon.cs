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
        Graphics graphic;
        public Hexagon(List<int> ArrayPoints, Graphics graphics)
        {
            graphic = graphics;

            try
            {
                for (int i = 0; i < 12; i++)
                {
                    point.Add(ArrayPoints[i]);
                }
            }
            catch { }
        }

        public override void PrintFigure()
        {
            Rendering rendering = new Rendering(point, graphic);
            rendering.PrintFigure(new DrawLine());
        }
    }
}
