using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); // 개체 생성
            car.Run();
            Console.ReadLine();
        }
    }
}
