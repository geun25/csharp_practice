using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 대화상자
{
    public partial class Form1 : Form
    {
        int Sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Dlg = new Form2();
            Dlg.ShowDialog();

            Sum = Dlg.x + Dlg.y;
            Dlg.Dispose();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("계산된 결과는" + Sum.ToString() + "입니다",
                Font, Brushes.Black, 10, 30);
        }       
    }
}
