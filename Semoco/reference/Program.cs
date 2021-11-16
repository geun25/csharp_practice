using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference
{
    class Car
    {
        public int a10 = 10;
    }

    class Program
    {
        string str1 = "반갑습니다"; // 전역변수

        static void Plus(int x) // 값만 복사해서 매개변수로 넘겨서 실제값은 영향 없음.
        {
            x = 100; // 지역변수
        }

        static void Plus(ref int x)
        {
            x = 100;
        }

        static void Plus1(Car car) // 참조에 의한 전달(값의 실제 주소를 전달하므로 실제 값도 변경)
        {
            car.a10 = 100;
        }

        static void Main(string[] args)
        {
            //값 형식
            int num1 = 1;
            int num2 = 2;
            num1 = num2;

            //참조형식
            Car car = new Car();
            Car car1 = new Car();
            car1 = car; // car1 변수의 스택영역에 car1의 힙주소가 들어감(이 힙주소에는 값이 존재)
            car.a10 = 50; // 여기에 car를 넣으면, car1의 스택영역에는 car의 힙 주소(이 힙주소에는 car의 값)가 들어감.

            Plus(num1);
            Plus(ref num2);
            //Plus1(car);
            Console.WriteLine($"값 : {num1}");
            Console.WriteLine($"참조 : {num2}");
            Console.WriteLine($"car의 a10값 : {car.a10}");
            Console.WriteLine($"car1의 a10값 : {car.a10}");
            Console.ReadLine();
        }
    }
}
