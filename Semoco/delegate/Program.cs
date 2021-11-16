using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        delegate void Del(); // delegate 정의
        Del manager; // delegate 객체선언

        Class1 class1 = new Class1();
        Class2 class2 = new Class2();
        Class3 class3 = new Class3();

        public Program()
        {
            // 이벤트 핸들러처럼 메서드를 등록해놓고, 사용하는 델리게이트 체인
            manager += new Del(class1.StringPlus1);
            manager += delegate { Console.WriteLine("hello2"); };
            manager += class3.StringPlus3;
            manager += (() => Console.WriteLine("hello4"));
        }
        static void Main(string[] args)
        {
            //new Program().manager();
            
            Class1 class1 = new Class1();

            new Thread(new ThreadStart(class1.StringPlus1)).Start(); // thread에 전달되는 델리게이트

            Manager(class1.StringPlus1); // 콜백을 받는 함수 실행
            Console.ReadLine();
        }

        static void Manager(Del dele) // 콜백함수를 매개변수로 받는 함수
        {
            dele();
        }
    }

    class Class1
    {
        public void StringPlus1()
        {
            Console.WriteLine("hello1");
        }
    }

    class Class2
    {
        public void StringPlus2()
        {
            Console.WriteLine("hello2");
        }
    }

    class Class3
    {
        public void StringPlus3()
        {
            Console.WriteLine("hello3");
        }
    }
}
