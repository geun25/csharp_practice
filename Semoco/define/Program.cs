using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace define
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Dog dog2 = new Dog(10);
        }
    }

    class Dog
    {
        public Dog()
        {
            Console.WriteLine("강아지 생성");
        }

        public Dog(int age)
        {
            Console.WriteLine($"{age}살 짜리 강아지 생성");
        }
    }
}
