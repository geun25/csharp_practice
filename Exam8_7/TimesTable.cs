using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_7
{
    class TimesTable
    {
        public int Base { get; set; }

        public TimesTable(int ibase)
        {
            Base = ibase;
        }

        public TimesTable():this(2)
        {
        }

        public void PrintBase()
        {
            for(int i=1;i<=9; i++)
            {
                Console.WriteLine($"{Base} * {i} = {Base*i}");
            }
        }
    }
} 
