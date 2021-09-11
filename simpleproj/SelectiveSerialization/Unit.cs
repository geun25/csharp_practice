using System;

namespace SelectiveSerialization
{
    [Serializable]// 직렬화 대상으로 형식 정의
    class Unit
    {
        [NonSerialized] // 유닛 개체 중에 공부한 횟수는 직렬화 대상에서 배제
        int scnt;// 공부한 횟수
        internal string Name
        {
            get;
            private set;
        }

        internal int IQ
        {
            get;
            private set;
        }

        internal Unit(string name)
        {
            Name = name;
            IQ = 0;
        }

        internal void Study()
        {
            scnt++;//공부한 횟수 1증가
            if (scnt == 5)//공부한 횟수가 5 되면 아이큐 1 증가 및 공부한 횟수 0으로 리셋
            {
                IQ++;
                scnt = 0;
            }
        }

        public override string ToString() // 이름, 아이큐, 공부한 시간
        {
            return string.Format($"{Name} {IQ} {scnt}");
        }
    }
}
