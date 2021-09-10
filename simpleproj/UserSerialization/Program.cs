using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace UserSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("김도근", 25);
            FileStream fs = new FileStream("man.xml", FileMode.Create);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, man);
            fs.Close();
            Console.WriteLine(man);

            FileStream fs2 = new FileStream("man.xml", FileMode.Open);
            SoapFormatter sf2 = new SoapFormatter();
            Man man2 = sf.Deserialize(fs2) as Man;
            fs2.Close();
            Console.WriteLine(man2);
        }
    }
}
