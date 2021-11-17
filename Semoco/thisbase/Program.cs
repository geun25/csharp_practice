using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisbase
{
    class Program : Parent
    {
        static void Main(string[] args)
        {
            new Program().AllPrint();
        }

        public void AllPrint()
        {
            base.Print(); // 부모클래스의 메서드 호출
            Print(); // 자식클래스의 메서드 호출
        }

        public override void Print()
        {
            Console.WriteLine("자식 클래스입니다.");
        }
    }

    class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("부모 클래스입니다.");
        }
    }
}
