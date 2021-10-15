using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var iCalc = new Calc<int>();
            var x = iCalc.Add(1, 2);

            var dCalc = new Calc<double>();
            var y = dCalc.Add(1.0, 3.14);

            List<string> nameList = new List<string>();
            nameList.Add("홍길동");

            List<int> intList = new List<int>();
            intList.Add(100);

            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores.Add("홍길동", 100);
        }
    }
}
