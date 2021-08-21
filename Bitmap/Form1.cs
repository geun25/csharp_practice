using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(400, 300);
            SetClientSizeCore(400, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.Yellow);
            bitmapGraphics.DrawRectangle(Pens.Black, 100, 10, 200, 100);
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
