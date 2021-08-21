using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam14_1
{
    class Exam14_1
    {
        public void Run()
        {
            TestDirectory();
        }

        private void TestDirectory()
        {
            //Console.Write("Directory 입력: ");
            //string root = Console.ReadLine();
            //CreateDirectory(root);
            //ReadDirectory(root);
            //DeleteDirectory(root);
            //RenameDirectory(root);
            //CRUD
            string fileSystem = "c:";
            string directory1 = "Windows";
            string root = Path.Combine(fileSystem, directory1);
            Console.WriteLine(root);
            ReadDirectory(root);
        }

        private void RenameDirectory(string root)
        {
            try
            {
                Directory.Move(root, "d:\\kdg");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DeleteDirectory(string root)
        {
            try
            {
                if (Directory.Exists(root)) Directory.Delete(root);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"오류발생: {ex.Message}");
                return;
            }
        }

        private void CreateDirectory(string root)
        {
            if (!Directory.Exists(root)) // 디렉터리가 없다면
            {
                Directory.CreateDirectory(root);
                return;
            }
        }

        private void ReadDirectory(string root)
        {
            if (Directory.Exists(root))
            {
                Console.WriteLine($"{root} 디렉터리가 존재합니다.");
                DirectoryInfo di = new DirectoryInfo(root);
                
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                    Console.WriteLine($"파일 {file.FullName}{file.Extension}을 찾았습니다.");
                
                string[] subdirs = Directory.GetDirectories(root);
                foreach (string dir in subdirs)
                    Console.WriteLine($"디렉터리 {dir}을 찾았습니다.");
            }
        }
    }
}
