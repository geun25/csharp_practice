using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Taxi : Car
    {
        public override void Run()
        {
            Console.WriteLine("Taxi Run!!");
        }
    }
}
