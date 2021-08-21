using System;
using System.Threading;
using System.Security.Permissions;

namespace InterruptingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Runiimg thread isn't gonnna be interrupted");
                Thread.SpinWait(1000000000); // 스레드를 대기하게 하지만 Sleep()과는 다르게 스레드가 Running 상태를 유지하게 함.

                while(count > 0)
                {
                    Console.WriteLine($"{count--} left");

                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10); // WaitSleepJoin 상태가 되어 인터럽트 발생
                }
                Console.WriteLine("Count : 0");
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Interrupting thread...");
            t1.Interrupt();

            Console.WriteLine("Waiting until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
