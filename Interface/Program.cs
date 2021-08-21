using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// interface
// 구현없이 형식만 포함
// 다중상속가능
// 상속으로만 사용하고 생성은 불가

namespace Interface
{
    interface IA
    {
        void PrintA();
    }

    interface IB
    {
        void PrintB();
    }

    class C : IA, IB
    {
        public void PrintA()
        {
            Console.WriteLine("interface A");
        }

        public void PrintB()
        {
            Console.WriteLine("interface B");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C Test = new C();
            Test.PrintA();
            Test.PrintB();
        }
    }
}
