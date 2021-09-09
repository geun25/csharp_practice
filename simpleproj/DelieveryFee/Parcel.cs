using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFee
{
    public class Parcel
    {
        public const int base_fee = 100;
        double weight;

        public Parcel(double weight)
        {
            this.weight = weight;
        }

        public double CalculateFee(double distance)
        {
            return weight * base_fee * distance;
        }
    }
}
