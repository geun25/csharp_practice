using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Tools;
using ClassLibrary.Extensions;

namespace LibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager log = new LogManager(null, "_LibTest");

            log.WriteLine("[Begin Processing]----");

            for(int index = 0; index < 10; index++)
            {
                log.WriteLine("Processing: " + index);

                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done: " + index);
            }
            log.WriteLine("[End Processing]----");

            string temp = "test";

            Console.WriteLine("IsNumeric? : " + temp.IsNumeric()); 
            Console.WriteLine("IsDateTime? : " + temp.IsDateTime()); 
        }
    }

    public static class ExtensionTest
    {
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
            Console.WriteLine(data);
        }
    }
}
