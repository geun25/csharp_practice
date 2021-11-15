using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Bus : Car
    {
        public void Go()
        {
            Console.WriteLine("Go Bus!!");
        }

        public override void Run()
        {
            Console.WriteLine("Bus Run!!");
        }
    }
}
