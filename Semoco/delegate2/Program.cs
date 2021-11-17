using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            //델리게이트 사용
            Action<int> action = (int s) => { Console.WriteLine(s + 5); };
            action(a);

            Func<int, int> func = (int s) => { return s + 5; };
            Console.WriteLine(func(a));

            Predicate<int> predicate = delegate (int s)
            {
                return s > 5;
            };
            Console.WriteLine(predicate(a));

            // 델리게이트 미사용시...
            Program program = new Program();
            program.Plus(a);

            Console.ReadLine();
        }

        void Plus(int s)
        {
            Console.WriteLine(s + 5);
        }
    }
}
