using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_1
{
    public class IfTestMgr
    {
        public void Run()
        {
            // 프로그램 시작
            PrintResult(GetDigit());
        }

        private void PrintResult(int digit)
        {
            //범위 오류체크
            if (digit < 0 || digit > 100)
            {
                Console.WriteLine("숫자가 아니거나 또는 범위를 벗어났습니다");
                return;
            }
            if (digit > 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고하셨습니다");
            }
        }

        private int GetDigit()
        {
            Console.WriteLine("숫자 입력하세요");
            string val = Console.ReadLine();
            return ConvertString2Int(val); // val = =1은 에러
        }

        private int ConvertString2Int(string str)
        {
            int result = 0;
            bool ret = int.TryParse(str, out result);
            if (ret)
                return result;
            else
                return -1; // error
        }
    }
}
