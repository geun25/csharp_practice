using MyLibrary;
using System;

namespace Exam8_4
{
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public SexEnum Sex { get; set; }

        public void ReadProperty()
        {
            Name = MyUtil.GetName();
            Score = MyUtil.GetDigit(0, 100);
            Sex = MyUtil.GetSex();
        }
    }
}
