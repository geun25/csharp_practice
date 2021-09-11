using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SelectiveSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit("김도근");
            unit.Study();
            unit.Study();
            unit.Study();
            unit.Study();
            unit.Study();
            unit.Study();
            unit.Study();
            FileStream fs = new FileStream("Data.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, unit);
            fs.Close();

            FileStream fs2 = new FileStream("Data.txt", FileMode.Open);
            BinaryFormatter bf2 = new BinaryFormatter();
            Unit unit2 = bf2.Deserialize(fs2) as Unit;
            fs2.Close();
            Console.WriteLine(unit2);
        }
    }
}
