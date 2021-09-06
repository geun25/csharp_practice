namespace CrossThread
{
    public delegate void FileMoveEventHandler(object sender, FileMovedEventArgs e);
    public class FileMovedEventArgs
    {
        public string FileName
        {
            get;
            private set;
        }

        public FileMovedEventArgs(string filename)
        {
            FileName = filename;
        }
    }
}
