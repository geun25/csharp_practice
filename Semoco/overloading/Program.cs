using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Add(a, b);
            Sum(1);
            Sum(1,2);
            Sum(1,2,3);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        // 메서드 오버로딩
        static int Add(double a, int b)
        {
            return int.Parse(a.ToString()) + b;
        }

        //가변길이 매개변수
        static void Sum(params int[] ints)
        {
            int sum = 0;
            foreach(int x in ints)
            {
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
