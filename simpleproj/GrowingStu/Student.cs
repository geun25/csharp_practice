namespace GrowingStu
{
    class Student
    {
        readonly int pn;

        internal string Name
        {
            get;
            private set;
        }

        int iq;
        internal int IQ
        {
            get
            {
                return iq;
            }
            private set
            {
                if (value > StuConst.MAX_IQ)
                    value = StuConst.MAX_IQ;
                if (value < StuConst.MIN_IQ)
                    value = StuConst.MIN_IQ;
                iq = value;
            }
        }

        int hp;
        internal int HP
        {
            get
            {
                return hp;
            }
            private set
            {
                if (value > StuConst.MAX_HP)
                    value = StuConst.MAX_HP;
                if (value < StuConst.MIN_HP)
                    value = StuConst.MIN_HP;
                hp = value;
            }
        }

        int stress;
        internal int Stress
        {
            get
            {
                return stress;
            }
            private set
            {
                if (value > StuConst.MAX_STRESS)
                    value = StuConst.MAX_STRESS;
                if (value < StuConst.MAX_STRESS)
                    value = StuConst.MAX_STRESS;
                stress = value;
            }
        }

        int scnt;
        internal int SCNT
        {
            get
            {
                return scnt;
            }
            private set
            {
                if (value < StuConst.MAX_SCNT)
                    scnt = value;
            }
        }

        static int lastpn;
        internal Student(string name)
        {
            Name = name;
            lastpn++;
            pn = lastpn;
            IQ = StuConst.DEF_IQ;
            HP = StuConst.DEF_HP;
            Stress = StuConst.DEF_STRESS;
        }

        internal void Study()
        {
            HP -= 5;
            IQ += SCNT;
            Stress += 2;
            SCNT++;
        }

        internal void ListenLecture()
        {
            HP += 3;
            IQ += SCNT;
            Stress += SCNT;
            SCNT++;
        }

        internal void Sleep()
        {
            HP += 10;
            Stress -= 5;
            SCNT = 0;
        }

        internal void Relax()
        {
            HP += 3;
            Stress -= 25;
            SCNT = 0;
        }

        internal void Drink()
        {
            HP += 5;
            IQ -= 10;
            Stress += 2;
            SCNT = 0;
        }

        internal void Sing()
        {
            HP += 10;
            IQ += (SCNT - 5);
            Stress += (5 - SCNT);
            SCNT = 0;
        }

        public override string ToString()
        {
            return string.Format($"{Name} < {pn} >");
        }
    }
}
