using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extended
{
    public static class ExtendedMethod
    {
        public static string ToPlus(this string a, string b) // 확장하려는 타입 a앞에 this키워드
        {
            return a + b;
        }
    }
}
