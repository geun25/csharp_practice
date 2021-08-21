using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("홍길동");
            //Student student3 = new Student("홍길동", "서울특별시");

            //student1.Name = "홍길동";
            student1.SetAge(1000);
            student1.SetAge(-1);
            Console.WriteLine(student2.Name);
            student1.printName();
        }
    }
}