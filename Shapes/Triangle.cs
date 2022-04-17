using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Triangle: Figure
    {
        Graphics graphic;
        public Triangle(List<int> ArrayPoints, Graphics graphics)
        {
            graphic = graphics;

            try
            {
                for (int i = 0; i < 6; i++)
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
