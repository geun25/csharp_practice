using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynTest
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = "aaa"; // 컴파일시 어떤 타입인지 체크하지 않고, 런타임시에 판별.
            Console.WriteLine(a.GetType()); // System.String
            a = 123;
            Console.WriteLine(a.GetType()); // System.Int32

            // object(casting 필요) vs dynamic(casting 필요 x) 
            object i = 10;
            i = (int)i + 20;

            i = "Hello";
            string s = ((string)i).ToUpper();
        }

        void ExpandoTest()
        {
            dynamic person = new ExpandoObject();

            //속성 추가
            person.Name = "Kim";
            person.Age = 10;

            //메서드 정의
            person.DisplayData = (Action)(() =>
            {
                Console.WriteLine($"{person.Name}: {person.Age}");
            });

            //이벤트 정의
            person.AgeChanged = null;

            person.ChangeAge = (Action<int>)((age) =>
            {
                person.Age = age;
                if(person.AgeChanged != null)
                {
                    person.AgeChanged(this, EventArgs.Empty);
                }
            });

            new Class2().Run(person); // 다른 어셈블리에 있는 클래스에도 전달가능하다.
        }
    }

    class Class1
    {
        public void Test()
        {
            dynamic t = new { Name = "Kim", Age = 25 };
            new Class2().Run(t); // 익명타입의 객체를 다른 클래스의 매서드를 호출할때 파라미터로 전달
        }
    }

    class Class2
    {
        public void Run(dynamic o)
        {
            // dynamic 타입의 속성 직접 사용
            Console.WriteLine(o.Name);
            Console.WriteLine(o.Age);
        }
    }
}
