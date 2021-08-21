using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam14_2
{
    class Exam14_2
    {
        Student[] students = new Student[3];

        public void Run()
        {
            //Student st = new Student();
            //Console.WriteLine(st.ToString());
            //Console.WriteLine(st); //WriteLine에 클래스 인스턴스를 주면 ToString을 먼저 호출
            
            ReadStudent();
            PrintStudent();
            WriteStudent();
        }

        private void ReadStudent()
        {
            FileStream stream = new FileStream(@"C:\Intel\student.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream, Encoding.Default);
            string buffer = null;
            int index = 0;
            while ((buffer = reader.ReadLine()) != null)          
                InsertStudent(buffer, index++);
            reader.Close();
        }
        
        private void InsertStudent(string buffer, int index)
        {
            Student st = new Student();
            string[] Intel = buffer.Split('#'); //Intel[0] Intel[1] Intel[2]
            if (Intel.Length != 3)         
                throw new Exception("텍스트 내용에 오류가 있습니다: " + buffer);
            st.Name = Intel[0];
            st.Score = int.Parse(Intel[2]); //Convert.ToInt32()
            int isex = int.Parse(Intel[1]);
            st.StudentSex = (Sex)Enum.ToObject(typeof(Sex), isex);
            students[index] = st;
        }
        
        private void PrintStudent()
        {
            foreach(Student stu in students)
                Console.WriteLine(stu);
        }
        
        private void WriteStudent()
        {
            FileStream stream = new FileStream(@"C:\Intel\student.bak", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, Encoding.Default);
            foreach (Student st in students)
                writer.WriteLine($"{st.Name}#{st.StudentSex}#{st.Score}");
            writer.Close();
        }
    }
}
