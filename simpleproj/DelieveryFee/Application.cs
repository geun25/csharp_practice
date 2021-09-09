using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFee
{
    class Application
    {
        #region 단일체 패턴
        static Application application;

        static Application()
        {
            application = new Application();
        }

        Application()
        { 
        }
        #endregion

        List<City> cities = new List<City>();

        internal static void Run()
        {
            application.Init();
            application.Simulation();
        }

        private void Init()
        {
            cities.Add(new City("부산", 0));
            cities.Add(new City("대구", 104.84));
            cities.Add(new City("대전", 259.24));
            cities.Add(new City("서울", 397.4));
        }

        private void Simulation()
        {
            City dep_city = SelectCity("도착 도시");
            if(dep_city == null)
            {
                Console.WriteLine("잘못 선택하였습니다.");
                return;
            }

            City arr_city = SelectCity("출발도시");
            if(arr_city == null)
            {
                Console.WriteLine("잘못 선택하였습니다.");
                return;
            }

            Parcel parcel = MakeParcel();
            PrintDeliveryFee(dep_city, arr_city, parcel);
        }

        private void PrintDeliveryFee(City dep_city, City arr_city, Parcel parcel)
        {
            double distance = dep_city.CalculateDistance(arr_city);
            Console.WriteLine($"택배요금:{parcel.CalculateFee(distance)}원");
            Console.ReadKey();
        }

        private Parcel MakeParcel()
        {
            Console.WriteLine("무게 :");
            double weight = 0;
            double.TryParse(Console.ReadLine(), out weight);
            return new Parcel(weight);
        }

        private City SelectCity(string msg)
        {
            Console.Write($"{msg} (");
            for (int i = 0; i < cities.Count; i++)
            {
                Console.Write($"{i}:{cities[i].Name}");
            }
            Console.Write("):");

            int index = 0;
            if (int.TryParse(Console.ReadLine(), out index) == false)
            {
                return null;
            }

            if ((index < 0) || (index >= cities.Count))
            {
                return null;
            }
            return cities[index];
        }
    }
}
