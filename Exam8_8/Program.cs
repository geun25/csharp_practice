using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeMul();
        }

        private static void ThreeMul()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
