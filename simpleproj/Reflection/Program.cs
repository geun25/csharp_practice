using System;
using System.Reflection;

// 리플렉션
// 런타임에 형식 멤버를 투영하여 사용하는 기술
// 명시적으로 라이브러리를 로딩하여 사용할 때 이용

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly asm = Assembly.Load("ManLib");

                //Type[] types = asm.GetTypes();
                //Console.WriteLine("제공하는 형식들");
                //foreach(Type type in types)
                //{
                //    Console.WriteLine(type);
                //}
                //Console.ReadKey();

                Type man_type = asm.GetType("ManLib.Man");
                if(man_type == null)
                    Console.WriteLine("Man 형식 리플렉션 실패");
                else
                {
                    Console.WriteLine("Man 형식 리플렉션 성공");

                    MemberInfo[] mis = man_type.GetMembers();
                    Console.WriteLine("Man 형식 멤버들");
                    foreach(MemberInfo mi in mis)
                    {
                        Console.WriteLine(mi);
                    }

                    Console.Clear();
                    object[] objs = new object[] { "김도근", 25 };
                    object mins = Activator.CreateInstance(man_type, objs); // 리플렉션하여 개체 생성
                    if(mins == null)
                    {
                        Console.WriteLine("Man 개체 생성 실패");
                        return;
                    }
                    Console.WriteLine(mins);

                    PropertyInfo pi = man_type.GetProperty("Num");
                    if(pi == null)
                    {
                        Console.WriteLine("Num 속성 리플렉션 실패");
                        return;
                    }
                    object num_val = pi.GetValue(mins, null);
                    Console.WriteLine($"Num:{num_val}");

                    MethodInfo mein = man_type.GetMethod("Study");
                    if(mein == null)
                    {
                        Console.WriteLine("Study 메서드 리플렉션 실패");
                        return;
                    }
                    object[] sobjs = new object[] { 3 };
                    Console.WriteLine($"결과:{mein.Invoke(mins, sobjs)}");
                    Console.WriteLine(mins);

                    object[] objs2 = new object[] { "강감찬", 3 };
                    object mins2 = Activator.CreateInstance(man_type, objs2);
                    if(mins2 == null)
                    {
                        Console.WriteLine("Man 개체 생성 실패");
                        return;
                    }

                    MethodInfo mein2 = man_type.GetMethod("MoreSmart");
                    if(mein2 == null)
                    {
                        Console.WriteLine("MoreSmart 메서드 리플렉션 실패");
                        return;
                    }

                    object[] objs3 = new object[] { mins, mins2 };
                    Console.WriteLine(mein2.Invoke(null, objs3));// 정적 멤버일 경우 첫번쨰 인자 null
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("ManLib가 없습니다.");
            }
        }
    }
}
