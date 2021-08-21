using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//override
// 상위 메서드 무시하고 하위에서 재정의 하는것
// 상위 클래스에는 virtual 명시
// 하위 클래스에는 override 명시

//overload
// 하나의 메서드명에 다양한 매개변수 적용

// Boxing / Unboxing
// 값 형태에만 적용
// 클래스는 상속 관계에 있으므로 참조변환이 된다.(upcasting, downcasting)

namespace Inheritance2
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A print");
        }

        public void Print(int num)
        {
            Console.WriteLine(num);
        }

        public float Print(int num, float pi)
        {
            Console.WriteLine("{0} {1}", num, pi);
            return pi;
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B print");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.Print(100);

            float pi = Test.Print(3, 3.14f);
            Console.WriteLine(pi);

            A Test1 = Test;
            Test1.Print();          

        }
    }
}
