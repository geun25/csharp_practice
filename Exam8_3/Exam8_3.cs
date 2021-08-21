using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_3
{
    class Exam8_3
    {
        public void Run()
        {
            EvalScore(MyUtil.GetDigit(0, 100));
        }

        private void EvalScore(int v)
        {
            if (v == -2)
                Console.WriteLine("성적이 범위를 초과했습니다.");
            else if (v == -1)
                Console.WriteLine("성적에 숫자가 아닌 문자가 있습니다.");
            else if (v > 90)
                Console.WriteLine("A");
            else if (v > 80)
                Console.WriteLine("B");
            else if (v > 70)
                Console.WriteLine("C");
            else if (v > 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
