using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; } 
        public int Age
        { 
            get 
            { 
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; 
            } 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "도근",
                Birthday=new DateTime(1997, 4, 25)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
