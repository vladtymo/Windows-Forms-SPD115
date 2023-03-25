using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_graphics.Shapes
{
    internal class MyLine : IShape
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Pen Pen { get; set; }

        public MyLine(Color color, float thickness, Point start, Point end)
        {
            Start = start;
            End = end;
            Pen = new Pen(color, thickness);
        }

        public void Print(Graphics graphics)
        {
            graphics.DrawLine(Pen, Start, End);
        }
    }
}
