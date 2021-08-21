using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 대화상자3
{
    public partial class Form1 : Form
    {
        int Number;
        string Message;
        public Form1()
        {
            InitializeComponent();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Number = 12;
            string Message = "Hello World!";
            Stream myStream;
            saveFileDialog1.DefaultExt = "dat";
            saveFileDialog1.Filter = "데이터(*.dat)|*.dat";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (BinaryWriter bw = new BinaryWriter(myStream))
                    {
                        bw.Write(Number);
                        bw.Write(Message);
                    }
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            openFileDialog1.Filter = "데이터(*.dat)|*.dat";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using (BinaryReader br = new BinaryReader(myStream))
                    {
                        Number = br.ReadInt32();
                        Message = br.ReadString();
                        Invalidate();
                    }
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(Number.ToString(), Font, Brushes.Black, 10, 30);
            e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 50);
        }
    }
}
