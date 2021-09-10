using System;

namespace Serialization
{
    [Serializable]
    class Man
    {
        internal string Name
        {
            get;
            private set;
        }

        internal int Age
        {
            get;
            private set;
        }

        internal Man(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format($"이름:{Name} 나이:{Age}");
        }
    }
}
