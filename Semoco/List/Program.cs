using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int a = 10;
            int b = 20;
            int c = 30;

            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.RemoveAt(0);

            foreach(int x in list)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

            //배열
            int[] ints1 = new int[] { 1, 2, 3, 4, 5 };
            ints1[0] = 10;
        }
    }
}
