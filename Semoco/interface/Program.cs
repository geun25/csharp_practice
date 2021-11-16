using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interf
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            List<Iinter1> list = new List<Iinter1>();
            list.Add(class1);
            list.Add(class2);

            foreach(Iinter1 x in list)
            {
                x.print();
            }

            Console.ReadLine();
        }
    }
}
