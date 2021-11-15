using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 다형성
            Bike bike = new Bike();
            Taxi taxi = new Taxi();
            Bus bus = new Bus();

            // Generic List 생성
            //List<Car> cars = new List<Car>();
            //cars.Add(bike);
            //cars.Add(taxi);
            //cars.Add(bus);

            //foreach(Car car in cars)
            //{
            //    car.Run();
            //}
            //Console.ReadLine();


            Car.Run1(); // 인스턴스를 따로 만들지 않고 사용 가능
            Car car = new Car();

            string result = "world";
            car.Run2(result);


            Console.ReadLine();
        }
    }
}
