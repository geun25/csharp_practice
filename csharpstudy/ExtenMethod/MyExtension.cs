using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenMethod
{
    public static class MyExtension
    {
        public static bool IsEven(this int a) // 확장 메서드의 특별한 파라미터 표기문법 (int a에 IsEven 메서드를 적용)
        {
            return a % 2 == 0;
        }

        // class 확장 메서드
        public static string DashAppend(this string s, string text)
        {
            return s + "-" + text;
        }

        public static int Modulo(this Calc calc, int a, int b)
        {
            return a % b;
        }
    }
}
