using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    class Circle : Shape, IDrawable
    {
        public int Radius { get; set; } = 50;

        public override void Clip()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            Point pt = Cursor.Position;
            g.DrawEllipse(Pens.Black, Location.X, Location.Y, 2 * Radius, 2 * Radius);
        }

        public override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
