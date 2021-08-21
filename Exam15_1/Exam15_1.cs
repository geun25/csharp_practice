using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Exam15_1
{
    class Exam15_1
    {
        ArrayList students = new ArrayList();
        public void Run()
        {
            //Boxing : 값 형식을 참조형식 object로 포인팅하면 Heap에 메모리 할당이 이루어지고 값이 저장
            //int a = 3;
            //object o = a;
            //ArrayList list = new ArrayList();
            //list.Add(3);
            //list.Add(4);
            //foreach(object o in list)
            //    Console.WriteLine(o);

            ReadStudent();
            students.Sort();
            PrintStudent();
            WriteStudent();
        }

        private void ReadStudent()
        {
            FileStream stream = new FileStream(@"C:\Intel\student.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
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
            st.StudentSex = isex;
            students.Add(st);
        }

        private void PrintStudent()
        {
            foreach (Student st in students)
                Console.WriteLine(st);
        }

        private void WriteStudent()
        {
            FileStream stream = new FileStream(@"C:\Intel\student.bak", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
            foreach (Student st in students)
                writer.WriteLine($"{st.Name}#{st.StudentSex}#{st.Score}");
            writer.Close();
        }                
    }
}
