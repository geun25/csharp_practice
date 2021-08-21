using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World Nice to Meet You";
            //Console.WriteLine(str.Contains("Nice"));
            //Console.WriteLine(str.IndexOf("World"));
            //Console.WriteLine(str.EndsWith("You"));
            //Console.WriteLine(str.Replace("Hello", "hi"));
            //Console.WriteLine(str.ToUpper());

            //string[] strs = str.Split(' ');
            //foreach(string s in strs)
            //    Console.WriteLine(s);
            //Console.WriteLine(str.Substring(1,3));

            //string str1 = "#####Hello World Nice to Meet You#######";
            //Console.WriteLine(str.Trim('#'));
            //Console.WriteLine(str.Equals(str1));

            Exam13_1 obj = new Exam13_1();
            obj.Run();
        }
    }
}
