using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Tools;
using ClassLibrary.Extensions;

namespace LibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager log = new LogManager(null, "_LibTest");

            log.WriteLine("[Begin Processing]----");

            for(int index = 0; index < 10; index++)
            {
                log.WriteLine("Processing: " + index);

                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done: " + index);
            }
            log.WriteLine("[End Processing]----");

            string temp = "test";

            Console.WriteLine("IsNumeric? : " + temp.IsNumeric()); 
            Console.WriteLine("IsDateTime? : " + temp.IsDateTime());

            string contents = "Hello there, <br />This is Derek.";
            EmailManager.Send("receiver@test.com", "Hi...", contents);
            EmailManager.Send("from@test.com", "receiver@test.com", "Hi...", contents);
            EmailManager.Send("from@test.com", "receiver@test.com", "Hi...", contents, "cc@test.com", "bcc@test.com");

            EmailManager email = new EmailManager("smtp.com", 25, "id", "password");
            email.From = "sender@test.com";
            email.To.Add("receiver@test.com");
            email.Subject = "Subject";
            email.Body = contents;
            email.Send();

            email.To.Clear();
            email.To.Add("receiver2@test.com");
            email.Subject = "Hi derek";
            email.Send();
        }
    }

    public static class ExtensionTest
    {
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
            Console.WriteLine(data);
        }
    }
}
