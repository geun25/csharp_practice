using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    class Program
    {
        Test test = new Test();
        static Test test1 = new Test();
        int test2 = 10;

        static void Main(string[] args)
        {
            test.InstanceMethod();
            test1.InstanceMethod();
            test2 = 20;

            test.field = 20;
            Test.sfield = 20;

            Test.StaticMethod();
            new Program().Main1();
            Console.ReadLine();
        }

        void Main1()
        {
            test.InstanceMethod();
            test1.InstanceMethod();
            test2 = 20;

            test.field = 20;
            Test.sfield = 20;

            Test.StaticMethod();
        }
    }

    class Test
    {
        public int field = 10;
        public static int sfield = 10;

        public static void StaticMethod()
        {
            Console.WriteLine("Static");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("Instance");
        }
    }
}
