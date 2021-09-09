using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFee
{
    public class City
    {
        readonly double relative_position;

        public string Name
        {
            get;
            private set;
        }

        public City(string name, double rp)
        {
            Name = name;
            this.relative_position = rp;
        }

        public double CalculateDistance(City city)
        {
            double distance = relative_position - city.relative_position;
            return Math.Abs(distance);
        }
    }
}
