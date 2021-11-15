using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Bike : Car
    {
        public override void Run()
        {
            Console.WriteLine("Bike Run!!");
        }
    }
}
