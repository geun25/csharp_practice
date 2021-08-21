using System;

namespace HistoryAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class,
        AllowMultiple = true)] // 애트리뷰트 중복 사용 가능 여부
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Sean", version = 0.1, changes = "2017-11-01")]
    [History("Bob", version = 0.2, changes = "2020-12-03")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("MyClass change history...");

            foreach (Attribute a in attributes)
            {
                History h = a as History;
                if(h != null)
                    Console.WriteLine($"Ver:{h.version}, Programmer:{h.GetProgrammer()}, Changes:{h.changes}");
            }
        }
    }
}
