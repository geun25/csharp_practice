using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam19_1
{
    class Exam19_1
    {
        public void Run()
        {
            var student = new Student();
            student.Name = "홍길동";
            student.Score = 10;

            var student2 = new Student { Name = "홍길동", Score = 90 };

            var st = new { Name = "황진이", Score = 60 };
            PrintMe(st);
        }

        public void PrintMe(dynamic st)
        {
            //출력은 되지만 추정하면서 프로그래밍 해야하는 숙명..
            Console.WriteLine(st.Name); 
            Console.WriteLine(st.Score);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
