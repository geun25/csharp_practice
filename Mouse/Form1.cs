using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse
{
    public partial class Form1 : Form
    {
        //string strMousePos;
        //List<Point> ListPoint = new List<Point>();
        Rectangle rectMouse;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //strMousePos = "X:" + e.X + " Y:" + e.Y;
            //Invalidate();
            if(e.Button == MouseButtons.Left)
            {
                rectMouse.Width = e.X - rectMouse.X + 1;
                rectMouse.Height = e.Y - rectMouse.Y + 1;
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawString(strMousePos, Font, Brushes.Black, 10, 10);
            //if(ListPoint.Count == 3)
            //{
            //    e.Graphics.DrawLine(Pens.Black, ListPoint[0], ListPoint[1]);
            //    e.Graphics.DrawLine(Pens.Black, ListPoint[1], ListPoint[2]);
            //    e.Graphics.DrawLine(Pens.Black, ListPoint[2], ListPoint[0]);
            //}
            string str = "left:" + rectMouse.X +
                         " top:" + rectMouse.Y +
                         " right:" + rectMouse.Right +
                         " bottom:" + rectMouse.Bottom;
            e.Graphics.DrawRectangle(Pens.Black, rectMouse);
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Point pt = new Point(e.X, e.Y);
            //if(ListPoint.Count == 3)
            //{
            //    ListPoint.Clear();
            //}
            //ListPoint.Add(pt);
            //Invalidate();
            rectMouse.X = e.X;
            rectMouse.Y = e.Y;
            rectMouse.Width = 0;
            rectMouse.Height = 0;
            Invalidate();
        }
    }
}
