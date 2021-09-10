using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("김도근", 25);
            FileStream fs = new FileStream("man.xml", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, man);
            fs.Close();

            FileStream fs2 = new FileStream("man.xml", FileMode.Open);
            //BinaryFormatter bf2 = new BinaryFormatter();
            SoapFormatter sf2 = new SoapFormatter();
            Man man2 = sf2.Deserialize(fs2) as Man;
            fs2.Close();
            Console.WriteLine(man2);
            Console.ReadKey();
        }
    }
}
