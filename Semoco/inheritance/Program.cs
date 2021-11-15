using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            Console.ReadLine();

            Bus bus = new Bus();
            bus.Go();
            bus.Run();
            int speed = bus.speed;
            Console.WriteLine(speed);
            Console.ReadLine();
        }
    }
}
