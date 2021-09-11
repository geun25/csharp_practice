using System;
using System.Runtime.Serialization;

namespace UserSerialization
{
    [Serializable]
    class Man : ISerializable
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
            return string.Format($"{Name} {Age}");
        }

        public Man(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("이름");
            Age = info.GetInt32("나이");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("이름", Name);
            info.AddValue("나이", Age);
        }
    }
}
