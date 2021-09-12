using System;

namespace ManLib
{
    public class Man
    {
        public const int max_iq = 200;
        int iq;

        public int IQ
        {
            get
            {
                return iq;
            }
            private set
            {
                if (value > max_iq)
                    value = max_iq;
                iq = value;
            }
        }

        public string Name
        {
            get;
            private set;
        }

        public int Num
        {
            get;
            private set;
        }

        public Man(string name, int num)
        {
            Name = name;
            Num = num;
            iq = 0;
            Console.WriteLine($"{this} 개체 생성");
        }

        public int Study(int scnt)
        {
            Console.WriteLine("Study");
            IQ += scnt; // 연속으로 공부한 횟수만큼 IQ 증가
            return IQ;
        }

        static public Man MoreSmart(Man m1, Man m2)
        {
            Console.WriteLine("Man.MoreSmart");
            if (m1.IQ > m2.IQ) // 두 개체중 IQ가 높은 개체 반환
                return m1;
            return m2;
        }

        public override string ToString()
        {
            return string.Format($"{Name} {Num} {IQ}");
        }
    }
}
