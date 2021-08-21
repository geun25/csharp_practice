using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam16_1
{
    class Exam16_1
    {
        public void Run()
        {
            PrintAny<int, string> p2 = new PrintAny<int, string>();
            p2.Print(5, "dgkim");
            PrintAny1 p3 = new PrintAny1();
            p3.Print(1, "kdg", 1.4);
        }
    }

    class PrintAny<T, U>
    {
        public void Print(T val1, U val2)
        {
            Console.WriteLine($"val = {val1}, val2 = {val2}");
        }
    }

    class PrintAny1
    {
        public void Print<T, U, V>(T val1, U val2, V val3)
        {
            Console.WriteLine($"val = {val1}, val2 = {val2}, val3 = {val3}");
        }
    }
}
