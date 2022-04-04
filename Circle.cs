﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Circle: Figure
    {
        public Circle(int[] ArrayPoints)
        {
            for (int i = 0; i < 4; i++)
            {
                point.Add(ArrayPoints[i]);
            }
        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            graphic.DrawEllipse(pen, point[0], point[1], point[2]-point[0], point[2]-point[0]);
        }
    }
}
