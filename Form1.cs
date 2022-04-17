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
        List<int> points = new List<int>();

        public Form1()
        {
            InitializeComponent();
            graphic = CreateGraphics();
        }

        private List<int> GetPoint(List<int> list)
        {
            List<int> pointXY = new List<int>() ;

            for (int i = 0; i < list.Count; i++)
            {
                pointXY.Add(list[i]);
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

        private void SelectionAndRendering(int index, List<int> Points)
        {
            CollectionOfFigures collection = new CollectionOfFigures(Points, graphic);

            foreach(Figure element in collection.figures)
            {
                if ((collection.figures.IndexOf(element)) == index)
                {
                    collection.figures[index].PrintFigure();
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.X);
            points.Add(e.Y);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SelectionAndRendering(comboBox1.SelectedIndex, GetPoint(points));
            ClearList(points);
        }

    }
}
