// Loader, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Loader.Program
using System.Diagnostics;
using System.Windows.Forms;

internal static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            CheckOtherLoaderInstances();
        }
        catch
        {
        }
        new Loader().Load(args);
    }

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
                switch (MessageBox.Show("There are other ExileCore2 instances running already", "ExileCore2 is already running", MessageBoxButtons.AbortRetryIgnore))
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
