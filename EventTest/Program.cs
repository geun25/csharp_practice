using System;

namespace EventTest
{
    delegate void EventHandler(string message); // 대리자 선언

    class MyNotifier
    {
        public event EventHandler SomethingHappened; // 대리자 인스턴스를 event 한정자로 수식선언
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : 짝", number));
            }
        }
    }

    class Program
    {
        //이벤트 핸들러, 대리자의 형식과 일치하는 메소드
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            //클래스 인스턴스 생성 및 이벤트 핸들러 등록
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
