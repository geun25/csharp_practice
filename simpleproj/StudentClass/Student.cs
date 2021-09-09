using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        #region 멤버 필드
        int iq; // 아이큐
        int cp; // 매력
        readonly int num; // 번호
        string name; // 이름
        static int lastnum; // 가장 최근에 부여한 번호
        #endregion

        #region 멤버 메소드
        public Student(string name) // 생성자
        {
            this.name = name;
            lastnum++;
            num = lastnum;
        }

        public void Study(int tcnt)
        {
            Console.WriteLine($"{num}번 {name}학생 {tcnt}횟수 공부하다");
            iq += tcnt;
        }

        public void Dance(int tcnt)
        {
            Console.WriteLine($"{num}번 {name}학생 {tcnt}횟수 춤하다");         
            cp += tcnt;
        }

        public void Sing(int tcnt)
        {
            Console.WriteLine($"{num}번 {name}학생 {tcnt}횟수 노래하다");
            iq += tcnt / 2;
            cp += tcnt / 2;
        }

        public override string ToString()
        {
            return string.Format($"번호{num} 이름{name}");
        }
        #endregion

        #region 멤버 속성
        public int IQ
        {
            get
            {
                return iq;
            }
            private set
            {
                iq = value;
            }
        }

        public int CP
        {
            get
            {
                return cp;
            }
            private set
            {
                cp = value;
            }
        }

        public int Num
        {
            get
            {
                return num;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public static int LastNum
        {
            get
            {
                return lastnum;
            }
        }
        #endregion
    }
}
