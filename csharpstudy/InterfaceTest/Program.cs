using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISendable> deliveryMethods = new List<ISendable>();
            deliveryMethods.Add(new Email());
            deliveryMethods.Add(new SnailMail());
            deliveryMethods.Add(new SMS());

            Alert(deliveryMethods, "Emergency msg...");
        }

        private static void Alert(List<ISendable> deliveryMethods, string msg)
        {
            foreach(ISendable s in deliveryMethods)
            {
                s.Send(msg);
            }
        }
    }
}
