using System;
using System.Windows.Forms;

namespace 대화상자2
{
    public partial class Form1 : Form
    {
        public string Message;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Dlg = new Form2();
            Dlg.Owner = this;
            Message = textBox1.Text;
            Dlg.ShowDialog();
            Dlg.Dispose();
        }
    }
}
