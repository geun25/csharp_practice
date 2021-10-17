using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }

        private async void Run()
        {
            //동기
            //int sum = LongCalc(10);
            //label1.Text = sum.ToString();

            //비동기
            var task1 = Task.Run(() => LongCalc(10));
            int sum = await task1;
            label1.Text = sum.ToString();
        }

        private int LongCalc(int n)
        {
            int result = 0;
            for(int i = 1; i <= n; i++)
            {
                result += i;
                // 긴 작업..............
                Thread.Sleep(1000); // 긴 작업으로 가정하고 시간연장
            }
            return result;
        }
    }
}
