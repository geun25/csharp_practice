using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonyType
{
    class Program
    {
        static void Main(string[] args)
        {
            // 익명타입
            var t = new
            {
                Name = "홍길동",
                Age = 20,
                Phone = "02-222-2222"
            };

            int age = t.Age; // Readonly이기 때문에 새로운 값 지정 못함.
            Type type = t.GetType();

            //LINQ
            var v = new[]
            {
                new { Name="Lee", Age=33, Phone="02-111-1111"},
                new { Name="Kim", Age=25, Phone="02-222-2222"},
                new { Name="Park", Age=37, Phone="02-333-3333"}
            };

            //LINQ SELECT를 이용해 30세 이상인 사람들 조회
            var list = v.Where(p => p.Age >= 30).Select(p => new { 이름 = p.Name, 나이 = p.Age });
            foreach(var a in list)
            {
                Debug.WriteLine(a.이름, a.나이);
            }
        }
    }
}
