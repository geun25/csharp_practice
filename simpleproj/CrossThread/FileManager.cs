using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CrossThread
{
    public static class FileManager
    {
        public static event FileMoveEventHandler FileMoveEventHandler = null;

        static List<string> source = new List<string>();
        public static List<string> Source
        {
            get
            {
                return source;
            }
        }

        /// <summary>
        /// 정적 생성자
        /// </summary>
        static FileManager()
        {
            DirectoryInfo di = new DirectoryInfo(src_dir);
            FileInfo[] fis = di.GetFiles(); // 파일 목록 컬렉션
            foreach(FileInfo fi in fis)
            {
                if (fi.Attributes == FileAttributes.Archive)
                    source.Add(fi.Name);
            }
        }

        static string src_dir = @"src\";
        static string dst_dir = @"dst\";

        delegate void MoveDele();
        public static void MoveStartAsync()
        {
            MoveDele dele = MoveStart;
            dele.BeginInvoke(null, null); // 비동기 실행 
        }

        public static void MoveStart()
        {
            while(source.Count > 0) // foreach 구문 사용시 컬렉션 변경할 때 예외가 발생.
            {
                MoveFile(source[0], src_dir, dst_dir);
            }
        }

        private static void MoveFile(string s, string src_dir, string dst_dir)
        {
            string src = string.Format($"{src_dir}{s}");
            string dst = string.Format($"{dst_dir}{s}");
            File.Move(src, dst);
            Thread.Sleep(1000); // 의도적으로 시간이 걸리는 작업처럼 지연
            if (FileMoveEventHandler != null)
                FileMoveEventHandler(null, new FileMovedEventArgs(s));
            source.Remove(s);
        }
    }
}