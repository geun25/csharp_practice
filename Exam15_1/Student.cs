using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam15_1
{
    class Student : IComparable
    {       
            public string Name { get; set; }
            public int StudentSex { get; set; }
            public int Score { get; set; }

        public int CompareTo(object obj)
        {
            Student st1 = obj as Student;
            //return Score - st1.Score;
            return Name.CompareTo(st1.Name);
        }

        public override string ToString()
            {
                return $"{Name}[{StudentSex}][{Score}]";
            }        
    }
}
