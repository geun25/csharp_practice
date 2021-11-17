using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqlamda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] strs = new string[5] { "a", "b", "c", "d", "e" };

            // LINQ
            IEnumerable<int> even = from num in nums
                                    where (num % 2) == 0
                                    select num;

            foreach(int num in even)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

            // var는 결과가 익명 형식이 되도록 할 때 사용할 수 있는 암시적 형식 지역변수
            var odd = nums.Where(o => o % 2 == 1);
            foreach(int num in odd)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();

            var str = strs.Where(o => o.Equals("a")).Select(o => o + "b");
            foreach(string s in str)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
