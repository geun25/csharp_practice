using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenMethod
{
    // 3rd party class that cannot modify  
    public sealed class Calc
    {
        public int Add(int a, int b) { return a + b; }
        public int Substract(int a, int b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }
    }
}
