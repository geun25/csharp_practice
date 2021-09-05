using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLogic2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\Users\jin yeong\Desktop\C#\연습\Practice", "*.txt");
            foreach(string file in files)
            {
                Thread t1 = new Thread(new ParameterizedThreadStart(Calculate));
                t1.Start(file);
            }
            Console.ReadLine();
        }

        static void Calculate(object dataFile)
        {
            // id, 국어, 영어 합계 / 출력파일 .txt
            string[] lines = File.ReadAllLines(dataFile.ToString());
            List<string> lines1 = new List<string>();
            foreach(string line in lines)
            {
                string id = line.Split(',')[0];
                int korean = int.Parse(line.Split(',')[1].ToString());
                int english = int.Parse(line.Split(',')[2].ToString());
                int sum = korean + english;
                lines1.Add(id + "," + korean + "," + english + "," + sum);
            }
            File.WriteAllLines(dataFile + ".txt", lines1);
            string dataFile1 = dataFile.ToString().Split('\\')[7];
            Console.WriteLine($"{DateTime.Now} : {dataFile1} - 완료");
        }
    }
}
