using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 학생 멤버 필드
// pn - 주민번호(순차 부여)
// name - 이름(생성 시 전달)
// iq - 초기 100, 0 ~ 200
// hp - 초기 100, 0 ~ 200
// stress - 초기 0, 0 ~ 100
// scnt - 연속으로 공부한 횟수(0~5), 공부하다 강의받다 이외의 행동하면 0으로 리셋
// lastpn - 최근에 부여한 주민 번호(정적 멤버)

namespace GrowingStu
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = Application.Singleton;
            app.Init();
            app.Run();
        }
    }
}
