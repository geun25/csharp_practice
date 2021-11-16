using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asis
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            new Program().AsTest(car);
        }

        void AsTest(object obj)
        {
            Car car = obj as Car;
            bool yes = obj is Car;
            Console.WriteLine(yes);
        }
    }

    class Car
    {

    }
}
