using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    class Student : Human
    {
        public int Grade { get; set; }
        public int StudentClass { get; set; }
        public int StudentId { get; set; }
        
        public void TakeExam()
        {
            Console.WriteLine("I'm taking a exam");
        }

        public override string ToString()
        {
            return $"{base.ToString()} 저는 {Grade}학년 {StudentClass}반 {StudentId}번인 {Name}입니다.";
        }
    } 
}
