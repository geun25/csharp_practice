using System;

namespace GrowingStu
{
    class Application
    {
        #region 단일체
        internal static Application Singleton
        {
            get;
            private set;
        }

        static Application()
        {
            Singleton = new Application();
        }

        Application()
        {
        }
        #endregion 단일체

        Student student = null;
        internal void Init()
        {
            Console.WriteLine("학생 키우기");
            Console.WriteLine("생성할 학생 이름을 입력하세요");
            Console.Write("이름:");
            string name = Console.ReadLine();
            student = new Student(name);
            Console.WriteLine("아무 키나 누르면 시작");
            Console.ReadKey(true);
        }

        internal void Run()
        {
            ConsoleKey key = ConsoleKey.NoName;
            while ((key = SelectMenu()) != ConsoleKey.Escape)//반복((키=메뉴 선택())!=종료키)
            {
                switch (key) //선택한 키에 따라
                {
                    case ConsoleKey.F1: Study(); break;
                    case ConsoleKey.F2: ListenLecture(); break;
                    case ConsoleKey.F3: Sleep(); break;
                    case ConsoleKey.F4: Relax(); break;
                    case ConsoleKey.F5: Drink(); break;
                    case ConsoleKey.F6: Sing(); break;
                    case ConsoleKey.F7: View(); break;
                    default: Console.WriteLine("잘못 선택하였습니다."); break;//다른 키: 잘못 선택한 것을 통보
                }
                Console.WriteLine("아무 키나 누르세요.");
                Console.ReadKey(true);//사용자가 결과 확인할 기회를 부여(아무 키나 누를 때까지 대기)
            }
        }

        private void View()
        {
            Console.WriteLine($"==={student}===");
            Console.WriteLine($"IQ:{student.IQ} HP:{student.HP} Stress:{student.Stress} SCNT:{student.SCNT}");
        }

        private void Sing()
        {
            Console.WriteLine($"{student} 노래하다");
            student.Sing();
        }

        private void Drink()
        {
            Console.WriteLine($"{student} 마시다");
            student.Drink();
        }

        private void Relax()
        {
            Console.WriteLine($"{student} 휴식하다");
            student.Relax();
        }

        private void Sleep()
        {
            Console.WriteLine($"{student} 잠자다");
            student.Sleep();
        }

        private void ListenLecture()
        {
            Console.WriteLine($"{student} 강의받다");
            student.ListenLecture();
        }

        private void Study()
        {
            Console.WriteLine($"{student} 공부하다");
            student.Study();
        }

        private ConsoleKey SelectMenu()
        {
            Console.Clear();
            Console.WriteLine("학생 키우기 메뉴");
            Console.WriteLine("{0}:공부하기", ConsoleKey.F1);
            Console.WriteLine("{0}:강의받기", ConsoleKey.F2);
            Console.WriteLine("{0}:잠자기", ConsoleKey.F3);
            Console.WriteLine("{0}:휴식하기", ConsoleKey.F4);
            Console.WriteLine("{0}:마시기", ConsoleKey.F5);
            Console.WriteLine("{0}:노래하기", ConsoleKey.F6);
            Console.WriteLine("{0}:정보보기", ConsoleKey.F7);
            Console.WriteLine("종료를 원하시면 {0}를 누르세요.", ConsoleKey.Escape);
            return Console.ReadKey(true).Key;
        }
    }
}