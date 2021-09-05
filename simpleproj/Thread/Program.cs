using System;
using System.Threading;

/// <summary>
/// 순서가 보장되지 않기 때문에 결과를 명확하게 기대하기 어려움.
/// </summary>
namespace ThreadLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(ThreadTest));
            thread.Start();

            for(int i=0; i<6; i++)
            {
                Console.WriteLine($"메인스레드{i}");
                Thread.Sleep(500);
            }

            thread.Join();
            Console.WriteLine("스레드 종료");
            Console.ReadLine();
        }

        static void ThreadTest()
        {
            for(int i =0; i<6; i++)
            {
                Console.WriteLine($"AddThread {i}");
                Thread.Sleep(500);
            }
        }
    }
}
