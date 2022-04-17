using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
   abstract public class Figure
   {
        private protected List<int> point = new();
        abstract public void PrintFigure();
   }

}
