using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class A
    {
        public int[] number = new int[3];
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            A[] Test = new A[2];
            Test[0] = new A();
            Test[1] = new A();
            Test[0].number[0] = 3;         
        }
    }
}
