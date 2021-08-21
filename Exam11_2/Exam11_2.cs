using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11_2
{
    class Exam11_2
    {
        public void Run()
        {
            Student[] students = new Student[]
            {
               new Student("이교준", 89, 2),
               new Student("김성훈", 78, 1)
            };
            Array.Sort(students);
            foreach(Student st in students)
                Console.WriteLine(st);
            FileStream stream = new FileStream(@"d:\temp\aa.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(stream))
            {
                string buffer;
                while ((buffer = reader.ReadLine()) != null)
                {

                }
            }
                
        }
    }

    class Student : IComparable, IDisposable
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }
        public Student(string name, int score, int id)
        {
            Name = name;
            Score = score;
            Id = id;
        }
        public override string ToString()
        {
            return $"{Name}[{Score}][{Id}]";
        }

        StreamReader reader;

        public int CompareTo(object obj)
        {
            Student st = obj as Student;
            //int ret = this.Name.CompareTo(st.Name);
            //return ret;

            //return Score - st.Score;

            return Id - st.Id; 
        }

        ~ Student()
        {
            Dispose(false);
        }

        bool disposed; //false
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void aaa()
        {
            FileStream stream = new FileStream(@"d:\temp\aa.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);           
            string buffer;
            while ((buffer = reader.ReadLine()) != null)
            {

            }            
        }

        public void Dispose(bool disposing)
        {
            if (disposed) return;
            if(disposing)
            {
                // c#에서 사용하는 IDisposable을 구현한 객체들 정리
                reader.Close();
                reader.Dispose();
            }
            else
            {
                //.NET Framework에서 관리되지 않는 자원들 정리
            }
            disposed = true;
        }
    }
}
