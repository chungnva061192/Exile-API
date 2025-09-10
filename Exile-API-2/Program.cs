// Loader, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Loader.Program
using System.Diagnostics;
using System.Windows.Forms;

namespace Loader
{
    // Token: 0x02000006 RID: 6
    internal static class Program
    {
        // Token: 0x06000021 RID: 33 RVA: 0x00002CAC File Offset: 0x00000EAC
        public static void Main(string[] args)
        {
            try
            {
                Program.CheckOtherLoaderInstances();
            }
            catch
            {
            }
            new Loader().Load(args);
        }

        // Token: 0x06000022 RID: 34 RVA: 0x00002CE0 File Offset: 0x00000EE0
        private static void CheckOtherLoaderInstances()
        {
            Process currentProcess = Process.GetCurrentProcess();
            bool flag = true;
            while (flag)
            {
                Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
                flag = false;
                if (processesByName.Length > 1)
                {
                    string text = "There are other ExileCore2 instances running already";
                    string text2 = "ExileCore2 is already running";
                    switch (MessageBox.Show(text, text2, MessageBoxButtons.AbortRetryIgnore))
                    {
                        case DialogResult.Abort:
                            currentProcess.Kill();
                            break;
                        case DialogResult.Retry:
                            flag = true;
                            break;
                        case DialogResult.Ignore:
                            return;
                    }
                }
            }
        }
    }
}
