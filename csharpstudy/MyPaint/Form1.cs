using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        private List<IDrawable> drawings = new List<IDrawable>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(IDrawable s in drawings) // resize문제 해결
            {
                s.Draw(e.Graphics);
            }
        }

        private void Custom_Draw()
        {
            Point loc = pictureBox1.PointToClient(MousePosition);

            //어셈블리 동적 로딩
            Assembly custom = Assembly.LoadFrom(@"C:\Users\rlaeh\source\repos\geun25\csharp_practice\csharpstudy\MyPaintCustom\bin\Debug\MyPaintCustom.dll");
            Type pie = custom.GetType("MyPaintCustom.Pie");
            IDrawable obj = (IDrawable)Activator.CreateInstance(pie, loc.X, loc.Y, 100, 100, 100, 100, 150, 280);
            obj.Draw(pictureBox1.CreateGraphics());

            drawings.Add(obj);
        }
    }
}
