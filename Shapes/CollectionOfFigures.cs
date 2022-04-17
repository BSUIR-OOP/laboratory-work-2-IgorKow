using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class CollectionOfFigures
    {
        public List<Figure> figures;
        public CollectionOfFigures(List<int> Points, Graphics graphics)
        {
            figures = new List<Figure>()
            {
                new Circle(Points, graphics),
                new Hexagon(Points, graphics),
                new Rectangle(Points, graphics),
                new Segment(Points, graphics),
                new Trapezium(Points, graphics),
                new Triangle(Points, graphics)
            };
        }
    }
}
