using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load event");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strResult = "체크 1: " + checkBox1.CheckState + 
                "체크 2 " + checkBox2.CheckState + 
                "체크 3: " + checkBox3.CheckState;
            MessageBox.Show(strResult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("radio 1 선택");
            else if (radioButton2.Checked)
                MessageBox.Show("radio 2 선택");
            if (radioButton3.Checked)
                MessageBox.Show("radio 3 선택");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                MessageBox.Show("radio 4 선택");
            else if (radioButton5.Checked)
                MessageBox.Show("radio 5 선택");
            if (radioButton6.Checked)
                MessageBox.Show("radio 6 선택");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int C = Convert.ToInt32(textBox1.Text);
            int CP = Convert.ToInt32(textBox2.Text);
            int CS = Convert.ToInt32(textBox3.Text);

            float Avg = (C + CP + CS) / 3.0f;
            string Result = Avg.ToString("f1");
            MessageBox.Show($"평균점수 : {Result}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = comboBox1.SelectedIndex;
            string FruitName = comboBox1.Text;
            textBox4.Text = Index.ToString();
            textBox5.Text = FruitName;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.SelectedIndex.ToString();
            textBox5.Text = listBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text);
            textBox6.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
