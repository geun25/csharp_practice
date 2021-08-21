using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_10
{
    class Exam8_10
    {
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Blank(i);
                Star(i);
                PrintNewLine();
            }
        }

        void Blank(int i)
        {
            for(int k =0; k<4-i; k++)
                Console.Write(" ");
        }

        void Star(int i)
        {            
            for(int j=0; j<2*i+1; j++)              
                Console.Write("*");                           
        }

        void PrintNewLine()
        {
            Console.WriteLine();
        }
    }
}
