using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @event
{
    class Program
    {
        public event EventHandler Event1;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Event1 += EventHandler1; // 이벤트 가입

            program.EventStart();
        }

        private static void EventHandler1(object sender, EventArgs e)
        {
            Console.WriteLine("이벤트 핸들러 동작");
        }

        private void EventStart()
        {
            Console.WriteLine("이벤트발생");
            Event1(this, EventArgs.Empty); // Click과 같은 역할
        }
    }
}
