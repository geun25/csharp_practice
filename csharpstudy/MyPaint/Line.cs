using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Line : Shape, IDrawable
    {
        public int Length { get; set; } = 50;
        public override void Clip()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            Point pt2 = new Point(Location.X + Length, Location.Y + Length);
            g.DrawLine(Pens.Blue, Location, pt2); 
        }

        public override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
