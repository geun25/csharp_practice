using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam17_1
{
    class Exam17_1
    {
        delegate void MyDelegate(int val); // 대리자의 선언
        delegate int MyDelegate1(int val);  

        public void Run()
        {
            DelegateTest(3); // 함수호출

            //익명메소드
            MyDelegate dele = delegate (int a)
            {
                Console.WriteLine($"{a+3}");
            };
            dele(6);

            dele = new MyDelegate(DelegateTest);
            dele(4);

            MyDelegate1 dele1 = new MyDelegate1(DelegateTest1);          
            Console.WriteLine(dele1(5));
        }

        private void DelegateTest(int myVal)
        {
            Console.WriteLine($"DelegateTest() called {myVal}");
        }

        private int DelegateTest1(int myVal)
        {
            return myVal + 1;
        }
    }
}
