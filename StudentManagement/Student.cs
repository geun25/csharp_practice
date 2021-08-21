using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        //필드, 프로퍼티
        public Grade StGrade { get; set; }
        public StudentClass StClass { get; set; }
        public int StNumber { get; set; }
        public string Name { get; set; }
        public Sex StSex { get; set; } // Enum Sex 참조

        //생성자
        public Student(Grade grade, StudentClass stclass, int stnumber, string name, Sex sex)
        {
            this.StGrade = grade;
            this.StClass = stclass;
            this.StNumber = stnumber;
            this.Name = name;
        }

        public Student(Grade grade, StudentClass stclass, int stnumber, string name)
            : this(grade, stclass, stnumber, name, Sex.미확인)
        {
        }

        public void PrintMe()
        {
            Console.WriteLine(StGrade + ":" + StClass + ":" + StNumber + " [" + Name + "]");
        }
    }    
}
            //메소드
