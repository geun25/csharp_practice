using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 대화상자2
{
    public partial class Form2 : Form
    {
        string Message;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 MainForm = (Form1)Owner;
            Message = MainForm.Message;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 30);
        }
    }
}
