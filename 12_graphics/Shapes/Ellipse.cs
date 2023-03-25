using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_graphics.Shapes
{
    public class MyEllipse : IShape
    {
        public Brush Brush { get; set; }
        public Rectangle Rectangle { get; set; }

        public MyEllipse(Color color, Point location, Size size)
        {
            Brush = new SolidBrush(color);
            Rectangle = new Rectangle(location.X, location.Y, size.Width, size.Height);
        }

        public void Print(Graphics graphics)
        {
            graphics.FillEllipse(Brush, Rectangle);
        }
    }
}
