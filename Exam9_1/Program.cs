using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            //학생
            // 학년 반 번호 학번
            //사람
            // 성명 혈액형 국적 주소 전화번호
            // 동물
            // 나이 성별 몸무게

            /*
            Student st = new Student();
            Console.WriteLine(st.ToString());
            Human h1 = st; // 부모가 자식을 가르키는 상황
            Student st2 = h1 as Student; // 컴파일 때 형 변환

            Animal ani1 = new Animal();

            bool ret = ani1 is Student;
            */

            //Object
            /*
            Animal a = new Animal();
            //Console.WriteLine(a.ToString());
            Type type = a.GetType();

            Console.WriteLine("Type test: " + type.FullName);

            Animal b = new Animal();
            bool ret1 = a.Equals(b);

            string sa = "hello";
            string sb = "hello";
            bool sret = sa.Equals(sb);
            */

            /*
            // 메소드 override 1
            Student st = new Student();
            Console.WriteLine(st.ToString());
            Human h1 = new Human();
            Console.WriteLine(h1.ToString());
            Animal a1 = new Animal();
            Console.WriteLine(a1.ToString());

            Animal a2 = st;
            Console.WriteLine(a2.ToString());
            */

            Student a = new Student();
            a.Grade = 1;
            a.StudentClass = 10;
            a.StudentId = 35;
            a.Name = "홍길동";
            a.Address = "서울특별시";
            Console.WriteLine(a);

            Human h = a;
            Console.WriteLine(h.ToString());
            Console.WriteLine(a.ToString());
        }
    }
}
