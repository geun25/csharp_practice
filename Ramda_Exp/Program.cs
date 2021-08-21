using System;
using System.Collections.Generic;

namespace Ramda_ExpBodied
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        public FriendList() => Console.WriteLine("FriendList()"); // 생성자
        ~FriendList() => Console.WriteLine("~FriendList()");

        //public int Capacity => list.Capacity; // 읽기 전용

        public int Capacity //속성
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        //public string this[int index] => list[index]; // 읽기 전용
        public string this[int index] // 인덱서
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("good");
            obj.Add("excellent");
            obj.Add("perfect");
            obj.Add("great");

            obj.Remove("good");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "fuck";
            obj.PrintAll();
        }
    }
}
