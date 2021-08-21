using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//base키워드
// 상위 클래스의 생성자 또는 멤버 변수 및 메서드 호출

namespace Inheritance
{
    class A
    {
        int number;
        protected string name = "Hello";
        public A(int num)
        {
            number = num;
        }

        public void PrintA()
        {
            Console.WriteLine(number);
        }
    }
    class B : A
    {
        string name = "World";
        public B(int num):base(num)
        {
        }

        public void PrintB()
        {
            Console.WriteLine("{0} {1}", base.name, name );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B(3);
            Test.PrintA();
            Test.PrintB();
        }
    }
}
