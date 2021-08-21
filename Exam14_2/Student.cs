using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam14_2
{
    class Student
    {
        public string Name { get; set; }
        public Sex StudentSex { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{Name}[{StudentSex}][{Score}]";
        }
    }
}
