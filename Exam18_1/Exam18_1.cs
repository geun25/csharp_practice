using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Nullable ?
-C# 2.0 System.Nullable<T> 구조체를 의미
-값 형식의 초기값이 0으로 채워지는 문제를 해결하기 위함

Null병합연산자 ??
-C# 2.0 피연산자1 ?? 피연산자2
-참조형식 피연산자1이 null이 아니라면 그 값을 그대로 반환하고 null이라면 피연산자2의 값을 반환

Null조건연산자 ?
-C# 6.0 참조변수의 값이 null이라면 그대로 null을 반환하고 null이 아니라면 지정된 멤버를 호출
-null조건 연산자는 단독으로 사용할 수 없고, 반드시 해당 참조형 변수의 멤버를 접근하거나 배열 인덱스와 같은 부가적인 접근을 필요로 함
*/
namespace Exam18_1
{
    
    class Exam18_1
    {
        public void Run()
        {
            //Member m = new Member();
            //if(m.GetMarried.HasValue)
            //    Console.WriteLine(m.GetMarried == true ? "기혼" : "미혼");
            //else
            //    Console.WriteLine("정보없음");

            //int? aa = null;
            //aa = 10;
            //int? bb = aa;
            //int c = 10;
            //c = bb.Value;

            string name = "홍길동";
            Console.WriteLine(name == null ? "(null)" : name);
            Console.WriteLine(name ?? "(null)");

            List<int> list1 = new List<int>();
            List<int> list2 = null;
            Console.WriteLine(list1?.Count);            
            int? ret = list2?.Count;
            Console.WriteLine(ret == null ? "(null)" : ret.ToString());           
        }
    }

    class Member
    {
        //bool getMarried;
        //public bool GetMarried
        //{
        //    get { return getMarried; }
        //    set { getMarried = value; }
        //}

        public bool? GetMarried { get; set; } // false로 초기화

    }
}
