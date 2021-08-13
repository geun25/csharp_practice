using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Animal
    {
        private void A() // 내부 클래스
        {

        }

        protected void B() // 내부 클래스, 파생 클래스
        {

        }

        public void C() // 내/외부 클래스, 파생 클래스, 프로젝트
        {

        }

        public void AnimalMethod()
        {
            // 같은 클래스 내부에서 접근가능한 메소드
            A();
            B();
            C();
        }
    }

    class Human : Animal
    {
        public void HumanMethod()
        {
            //A(); // 같은 클래스에서만 접근 가능
            B();
            C();
        }
    }

    class PointC
    {
        public int x;
        public int y;

        public PointC(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
    }

    struct PointS // 상속불가, 인터페이스 구현 불가
    {
        public int x;
        public int y;

        public PointS(int x, int y) // 구조체의 생성자는 매개변수가 있어야 함.
        {
            this.x = x;
            this.y = y;
        }
    }

    class 접근제한자
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.HumanMethod();

            PointS p1 = new PointS(10, 20); // 구조체 객체 생성
            PointC p2 = new PointC(10, 20); // 클래스 객체 생성
            PointS p3 = p1; // 값에 의한 복사
            PointC p4 = p2; // 참조에 의한 복사

            Console.WriteLine($"{p1.x} {p1.y}");
            Console.WriteLine($"{p2.x} {p2.y}");

            p3.x = 11;
            p4.x = 11;

            Console.WriteLine($"{p1.x} {p2.y}");
            Console.WriteLine($"{p2.x} {p2.y}");
        }
    }

    
}
