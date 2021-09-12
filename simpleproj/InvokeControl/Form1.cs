using System;
using System.Diagnostics;
using System.Windows.Automation;
using System.Windows.Forms;

namespace InvokeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            lbox_process.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach(Process pro in processes) // 사용자와 상호작용 가능한 프로세스 선별
            {
                if (pro.MainWindowHandle != IntPtr.Zero)
                    lbox_process.Items.Add(new WrapProcess(pro));
            }
        }

        private void lbox_process_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox_inv_ele.Items.Clear();
            AutomationElement rae = SelectedWrapAE();
            if (rae == null) 
                return;

            AutomationEventHandler MyEventHandler = new AutomationEventHandler(OnUIAutomationEvent);
            Automation.AddAutomationEventHandler(InvokePattern.InvokedEvent, rae, TreeScope.Subtree, MyEventHandler);

            Condition cond = new PropertyCondition(AutomationElement.IsInvokePatternAvailableProperty, true);
            AutomationElementCollection aec = rae.FindAll(TreeScope.Subtree, cond);
            foreach(AutomationElement ae in aec)
            {
                lbox_inv_ele.Items.Add(new WrapInvoke(ae));
            }
        }

        void OnUIAutomationEvent(object sender, AutomationEventArgs e)
        {
            AutomationElement ae = sender as AutomationElement;
            AddEvent(ae); // lbox_history에 추가
        }

        delegate void AddEventDele(AutomationElement ae);
        private void AddEvent(AutomationElement ae)
        {
            if(lbox_history.InvokeRequired) // 크로스 스레드 발생 여부 확인
            {
                object[] objs = new object[1] { ae };
                lbox_history.Invoke(new AddEventDele(AddEvent), objs);
            }
            else
            {
                lbox_history.Items.Add(ae.Current.Name + "클릭");
            }
        }

        private AutomationElement SelectedWrapAE()
        {
            if(lbox_process.SelectedIndex == -1)
                return null;
            WrapProcess wp = lbox_process.SelectedItem as WrapProcess;
            return wp.RootElement;
        }

        private void lbox_inv_ele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_inv_ele.SelectedIndex == -1)
                return;
            WrapInvoke winvoke = lbox_inv_ele.SelectedItem as WrapInvoke;
            winvoke.Invoke();
        }
    }
}
