using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            //progrssBar1.PerformStep();
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }

            textBox1.Text = progressBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            imageList1.Draw(e.Graphics, 0, 0, 0);
            //imageList1.Draw(e.Graphics, 70, 0, 1);
        }
    }
}
