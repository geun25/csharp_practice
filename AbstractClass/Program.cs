using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// abstract class
// 구현하려는 메서드의 형태만 존재하는 클래스, 실제 구현은 하위에서 구현
// new를 통해 생성할 수 없고, 상속으로만 사용
namespace AbstractClass
{
    abstract class A
    {
        int num = 3;
        public abstract void Print();
        public void PrintNum()
        {
            Console.WriteLine(num);
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("abstract class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.PrintNum(); // 추상클래스 내 추상 메서드가 아닌 메서드는 사용가능
        }
    }
}
