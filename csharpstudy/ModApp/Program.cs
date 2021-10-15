using ModLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.LogSuccess("");

            string s = logger.LogDirectory;
        }
    }
}
