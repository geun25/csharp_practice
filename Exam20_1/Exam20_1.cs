using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
확장 메서드
기존 클래스의 내부구조를 전혀 바꾸지 않고 마치 새로운 인스턴스 메서드를 
정의하는 것처럼 추가할 수 있음
static 클래스에서 정의되어야 함
확장메서드는 반드시 static이어야 함
확장하려는 타입은 this 예약어와 함께 명시
 */

namespace Exam20_1
{
    static class MyClass
    {
        public static int GetWordCount(this string txt)
        {
            return txt.Split(' ').Length;
        }

        public static bool IsDigit(this string txt)
        {         
            int tmp;
            return int.TryParse(txt, out tmp);         
        }

        public static int? ConvertToInt(this string txt)
        {
            int tmp;
            if (int.TryParse(txt, out tmp)) return tmp;
            return null;
        }
    }

    class Exam20_1
    {
        delegate int? MyDivide(int a, int b);
        public void Run()
        {
            //MyDivide myDivide = (a, b) => a / b;
            //MyDivide myDivide = delegate (int a, int b)
            //{
            //    return a / b;
            //};
            //Console.WriteLine(myDivide(6, 3));

            //string kk = "Hello World!";
            //Console.WriteLine(kk.GetWordCount());
            string kk = "1133";
            Console.WriteLine(kk.IsDigit());          
            Console.WriteLine(kk.ConvertToInt());

        }       
    }
}
