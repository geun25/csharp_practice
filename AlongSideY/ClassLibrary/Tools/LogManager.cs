﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tools
{
    public enum LogType { Daily, Monthly }
    
    public class LogManager
    {
        private string _path;

        #region Constructors
        public LogManager(string path, LogType logType)
        {
            _path = path;
            _SetLogPath(logType);
        }

        public LogManager()
            : this(Path.Combine(Application.Root, "Log"), LogType.Daily)
        {
        }
        #endregion

        #region Methods
        private void _SetLogPath(LogType logType)
        {
            string path = String.Empty;
            string name = String.Empty;

            switch(logType)
            {
                case LogType.Daily:
                    path = String.Format(@"{0}\{1}\", DateTime.Now.Year, DateTime.Now.ToString("MM"));
                    name = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                    break;
                case LogType.Monthly:
                    path = String.Format(@"{0}\", DateTime.Now.Year);
                    name = DateTime.Now.ToString("yyyyMM") + ".txt";
                    break;
            }

            _path = Path.Combine(_path, path);
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

            _path = Path.Combine(_path, name);
        }

        public void Write(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.Write(data);
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        public void WriteLine(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss\t") + data);
                }
            }
            catch(Exception ex)
            {

            }
        }
        #endregion
    }
}
