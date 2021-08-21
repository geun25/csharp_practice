using MyLibrary;
using System;

namespace Exam8_5
{
    class Scholarship
    {
        public Scholarship()
        {
        }

        public void MakeStudent()
        {
            // 멤버변수로 선언한다면 복잡도가 올라감
            // 지역변수로 선언한다면 메소드밖에서는 사용하지 못하기 때문에 매개변수로 다른 함수에 넘겨줘야함,
            string name = null;
            SexEnum sex;
            int score;

            name = MyUtil.GetName();
            sex = MyUtil.GetSex();
            score = MyUtil.GetDigit();
            TestMe();
            EvalScholarShip(name, sex, score);
        }

        private void TestMe()
        {
            name = null; // 오류 상황
        }

        public void EvalScholarShip(string name, SexEnum sex, int score)
        {
            if(sex == SexEnum.오류)
            {
                MyUtil.ErrorMessage("성구분이 틀렸습니다.");
                return;
            }

            switch(sex)
            {
                case SexEnum.남성:
                    PrintMan(score);
                    break;
                case SexEnum.여성:
                    PrintWoman(score);
                    break;
                default:
                    break;
            }
        }

        void PrintMan(int score)
        {
            if (IsError(score)) return;
            if (score > 90) MyUtil.PrintMessage(name + ": 우수장학생");
            else if (score > 80) MyUtil.PrintMessage(name + ": 장학생");
            else MyUtil.PrintMessage("해당사항 없음");
        }

        void PrintWoman(int score)
        {
            if (IsError(score)) return;
            if (score > 90) MyUtil.PrintMessage("해외연수장학생");
            else if (score > 80) MyUtil.PrintMessage("국비장학생");
            else MyUtil.PrintMessage("해당사항 없음");
        }

        bool IsError(int value)
        {
            if (value == -2)
            {
                MyUtil.ErrorMessage("성적이 범위를 벗어났습니다.");
                return true;
            }
            return false;
        }
    }
}
