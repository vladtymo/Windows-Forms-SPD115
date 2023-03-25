using _12_graphics.Shapes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace _12_graphics
{
    public partial class Form1 : Form
    {
        enum ShapeType { Pen, Line, Ellipse, Rectangle }

        private bool isDrawing = false;
        private Point start;
        private ShapeType selectedType = ShapeType.Pen;

        private Graphics g = null;
        
        public Form1()
        {
            InitializeComponent();

            g = pictureBox.CreateGraphics();

            foreach (var item in Enum.GetValues(typeof(ShapeType)))
            {
                shapeTypeComboBox.Items.Add(item);
            }
            shapeTypeComboBox.SelectedIndex = 0;
        }

        private void DrawTestShapesClick(object sender, EventArgs e)
        {
            // Draw...() - відображення контура
            // Fill...() - заповнення внутрішньої частини 

            // ----------- pie -----------
            g.FillPie(Brushes.Gold, 200, 200, 100, 100, 90, 90);

            // ----------- rectangle -----------
            g.FillRectangle(Brushes.DarkCyan, 500, 200, 140, 250);

            // ----------- line -----------
            Pen bluePen = new Pen(Color.Blue, 6);
            // встановлення параметрів контура
            bluePen.StartCap = LineCap.SquareAnchor;
            bluePen.EndCap = LineCap.ArrowAnchor;
            bluePen.DashStyle = DashStyle.Dash;
            bluePen.DashCap = DashCap.Round;
            g.DrawLine(bluePen, 150, 250, 270, 200);

            // ----------- ellipse -----------
            // створення параметрів еліпса
            Point pt = new Point(300, 300);
            Size sz = new Size(100, 100);
            Rectangle rect1 = new Rectangle(pt, sz);
            Rectangle rect2 = new Rectangle(350, 350, 60, 60);
            g.FillEllipse(Brushes.Black, rect1);

            // cтворення контура еліпса
            Pen pn = new Pen(Brushes.Red, 4);
            
            g.DrawEllipse(pn, rect2);
        }

        private void NormalizeCoords(ref Point start, ref Point end)
        {
            if (end.X < start.X)
            {
                //int temp = start.X;
                //start.X = end.X;
                //end.X = temp;
                (end.X, start.X) = (start.X, end.X);
            }
            if (end.Y < start.Y)
            {
                (end.Y, start.Y) = (start.Y, end.Y);
            }
        }
        private Size GetSize(Point start, Point end)
        {
            return new Size()
            {
                Width = Math.Abs(end.X - start.X),
                Height = Math.Abs(end.Y - start.Y)
            };
        }

        // ------- working with Picture Box
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // початкові координати
            start = e.Location;
            isDrawing = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            // кінцеві координати
            Point end = e.Location;

            // визначаємо розмір прямокутника
            Size size = GetSize(start, end);

            IShape shape = null;
           
            switch (selectedType)
            {
                case ShapeType.Line:
                    shape = new MyLine(Color.Lime, 5, start, end);
                    break;
                case ShapeType.Ellipse:
                    // нормалізація координат
                    NormalizeCoords(ref start, ref end);
                    shape = new MyEllipse(Color.Red, start, size);
                    break;
                case ShapeType.Rectangle:
                    // нормалізація координат
                    NormalizeCoords(ref start, ref end);
                    shape = new MyRectangle(Color.Red, start, size);
                    break;
            }

            shape?.Print(g);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Cursor position: {e.X} : {e.Y}";

            if (isDrawing && selectedType == ShapeType.Pen)
            {
                g.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);
            }
        }

        private void shapeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = (ShapeType)shapeTypeComboBox.SelectedItem;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height, g);
            //bitmap.Save("image.png", ImageFormat.Png);
        }
    }
}