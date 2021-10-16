using MyPaint;
using System.Drawing;

namespace MyPaintCustom
{
    public class Pie : IDrawable
    {
        public Rectangle Rect { get; }
        public float StartAngle { get; }
        public float SweepAngle { get; }

        public Pie(int x, int y, int width, int height, float startAngle = 0, float sweepAngle = 0)
        {
            this.Rect = new Rectangle(x, y, width, height);
            this.StartAngle = startAngle;
            this.SweepAngle = sweepAngle;
        }

        public void Draw(Graphics g)
        {
            g.FillPie(Brushes.DarkGreen, Rect, StartAngle, SweepAngle);
        }
    }
}
