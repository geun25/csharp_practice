using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam15_2
{
    class Exam15_2
    {
        public void Run()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            int a = (int)list[0];

            List<double> list1 = new List<double>();
            list1.Add(1.24);
            double b = list1[0];
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
