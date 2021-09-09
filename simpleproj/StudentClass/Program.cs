using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("홍길동");
            Student stu2 = new Student("강감찬");
            Console.WriteLine(stu1);
            Console.WriteLine(stu2);

            stu1.Study(3);
            Console.WriteLine($"{stu1.Num} {stu1.Name} {stu1.IQ} {stu1.CP}");
            stu1.Dance(4);
            Console.WriteLine($"{stu1.Num} {stu1.Name} {stu1.IQ} {stu1.CP}");
            stu1.Sing(5);
            Console.WriteLine($"{stu1.Num} {stu1.Name} {stu1.IQ} {stu1.CP}");

            Console.WriteLine($"가장 최근에 부여한 학생 번호 {Student.LastNum}");
            Console.ReadKey();
        }
    }
}
