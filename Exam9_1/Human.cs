using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    class Human : Animal
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }

        //public Human()
        //{
        //    Console.WriteLine("Human " + this.ToString());
        //}

        public void Drawing()
        {
            Console.WriteLine("I'm drawing a picture");
        }

        public void Study()
        {
            Console.WriteLine("I'm studying C#");
        }

        public override string ToString()
        {
            return $"{base.ToString()} : 저의 주소는 {Address}";
        }
    }
}
