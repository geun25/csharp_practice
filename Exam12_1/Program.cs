using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            //Student st2 = new Student();
            Student st2 = st;
            st.Name = "Lee";
            st2.Name = "Kim";
            Console.WriteLine(st.Name);
            Console.WriteLine(st2.Name);
        }       
    }

    /// <summary>
    /// 참조 형식으로 학생 클래스입니다.
    /// </summary>
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
