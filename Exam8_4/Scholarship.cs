using MyLibrary;
using System;

namespace Exam8_4
{
    class Scholarship
    {
        public Student MyStudent { get; set; }

        public Scholarship(Student st)
        {
            MyStudent = st; 
        }

        public Scholarship():this(null)
        {
        }

        public void EvalScholarShip()
        {
            if(MyStudent == null)
            {
                MyUtil.ErrorMessage("평가할 학생이 없습니다.");
                return;
            }
            if(MyStudent.Sex == SexEnum.오류)
            {
                MyUtil.ErrorMessage("성구분이 틀렸습니다.");
                return;
            }
            if (MyStudent.Sex == SexEnum.남성)
            {
                if (IsError(MyStudent.Score)) return;
                if (MyStudent.Score > 90)
                    MyUtil.PrintMessage("우수장학생");
                else if (MyStudent.Score > 80)
                    MyUtil.PrintMessage("장학생");
                else MyUtil.PrintMessage("해당사항 없음");
            }
            else
            {
                if (IsError(MyStudent.Score)) return;
                if (MyStudent.Score > 90)
                    MyUtil.PrintMessage("해외연수장학생");
                else if (MyStudent.Score > 80)
                    MyUtil.PrintMessage("국비장학생");
                else MyUtil.PrintMessage("해당사항 없음");
            }
        }

        bool IsError(int value)
        {
            if (MyStudent.Score == -2)
            {
                MyUtil.ErrorMessage("성적이 범위를 벗어났습니다.");
                return true;
            }
            return false;
        }
    }
}
