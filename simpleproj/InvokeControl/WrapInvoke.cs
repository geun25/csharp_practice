using System.Windows.Automation;

namespace InvokeControl
{
    public class WrapInvoke
    {
        public AutomationElement AE
        {
            get;
            private set;
        }

        public string Name
        {
            get
            {
                return AE.Current.Name;
            }
        }

        public string ControlType
        {
            get
            {
                return AE.Current.LocalizedControlType;
            }
        }

        public WrapInvoke(AutomationElement ae)
        {
            AE = ae;
        }

        public void Invoke()
        {
            try
            {
                InvokePattern inv_pat = AE.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                inv_pat.Invoke();
            }
            catch
            {
                // 예외처리
            }
        }

        public override string ToString()
        {
            return ControlType + ":" + Name;
        }
    }
}
