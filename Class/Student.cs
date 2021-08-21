using System;

namespace Class
{
    public class Student
    {
        //private string name;
        private string address;
        private int age;

        #region 생성자
        public Student(string name, string address)
        {
            this.Name = name;
            this.address = address;
        }

        public Student(string name) : this(name, null)
        {
        }

        public Student() : this(null)
        {            
        }
        #endregion

        #region getter setter
        //getter: 메소드를 통해 private 변수 값만 밖에서 호출 가능
        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if (age < 0 || age > 121)
            {
                Console.WriteLine("나이는 음수나 120세를 넘을 수 없습니다");
                return;
            }
            this.age = age;
        }

        //Property 개념

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public string Name { get; set; } // 변수이자 property 역할
        #endregion

        public void printName()
        {
            Console.WriteLine("name = " + Name);
        }

        public void printAddress()
        {
            Console.WriteLine("address = " + address);
        }
    }
}
