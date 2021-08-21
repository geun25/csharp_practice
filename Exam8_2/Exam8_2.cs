using MyLibrary;
using System;

namespace Exam8_2
{
    public class Exam8_2
    {
        public void Run()
        {
            // 프로그램 시작   
            PrintResult(MyUtil.GetDigit());
        }

        private void PrintResult(int digit)
        {
            //범위 오류체크
            if (digit < 0 || digit > 100)
            {
                Console.WriteLine("숫자가 아니거나 또는 범위를 벗어났습니다");
                return;
            }
            if (digit >= 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고하셨습니다");
            }
            else
            {
                Console.WriteLine("보통");
            }
        }
    }
}
