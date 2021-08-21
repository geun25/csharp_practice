using MyLibrary;
using System;

namespace Exam9_1
{
    class Animal
    {
        public int Age { get; set; }
        public SexEnum Sex { get; set; }
        public int Weight { get; set; }

        //public Animal()
        //{
        //    Console.WriteLine("Animal " + this.ToString());
        //}

        public void Sleep()
        {
            Console.WriteLine("I'm sleeping now");
        }

        public void Eat()
        {
            Console.WriteLine("I'm eating banana");
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking on the street");
        }

        public override string ToString()
        {
            return "I'm an Animal";
        }
    }
}
