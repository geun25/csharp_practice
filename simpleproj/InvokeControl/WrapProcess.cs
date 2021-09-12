using System;
using System.Diagnostics;
using System.Windows.Automation;

namespace InvokeControl
{
    public class WrapProcess
    {
        public Process Process
        {
            get;
            private set;
        }

        public string Title
        {
            get
            {
                return Process.ProcessName + ":" + Process.MainWindowTitle;
            }
        }

        public AutomationElement RootElement
        {
            get
            {
                if(Process.MainWindowHandle == IntPtr.Zero)
                    return null;
                return AutomationElement.FromHandle(Process.MainWindowHandle);
            }
        }

        public WrapProcess(Process process)
        {
            Process = process;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
