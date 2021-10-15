using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Rect : Shape, IDrawable
    {
        public int Width { get; set; } = 50;
        public int Height { get; set; } = 50;

        public override void Clip()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, Location.X, Location.Y, Width, Height);
        }

        public override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
