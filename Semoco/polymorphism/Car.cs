using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Car
    {
        public virtual void Run()
        {
            Console.WriteLine("Run!!");
        }

        public static void Run1()
        {
            Console.WriteLine("Run1!!");
        }

        public void Run2(string c)
        {
            Console.WriteLine("hello" + c);
        }
    }
}
