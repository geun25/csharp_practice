using System;
using System.Windows.Forms;

namespace 대화상자
{
    public partial class Form2 : Form
    {
        public int x, y;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            Close();
        }       
    }
}
