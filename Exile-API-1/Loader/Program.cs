using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Loader;

internal class Program
{
	public static void Main(string[] args)
	{
		try
		{
			AskToKillOtherRunningProcesses();
		}
		catch
		{
		}
		new Loader().Load(args);
	}

	private static void AskToKillOtherRunningProcesses()
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
		bool flag = true;
		while (flag)
		{
			flag = false;
			if (processesByName.Length <= 1)
			{
				continue;
			}
			string caption = "Hud process is already running";
			switch (MessageBox.Show("Kill already running HUD process? No- wait 3sec until hud is closed", caption, MessageBoxButtons.YesNoCancel))
			{
			case DialogResult.Retry:
			{
				int num = 0;
				while (processesByName.Length > 1 && num < 10)
				{
					processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
					if (processesByName.Length == 1)
					{
						break;
					}
					Thread.Sleep(300);
					num++;
				}
				flag = processesByName.Length > 1;
				break;
			}
			case DialogResult.OK:
			{
				Process[] array = processesByName;
				foreach (Process process in array)
				{
					if (process.Id != currentProcess.Id && !process.HasExited)
					{
						process.Kill();
					}
				}
				break;
			}
			case DialogResult.Cancel:
				currentProcess.Kill();
				break;
			}
		}
	}
}
