using System.Diagnostics;
using System.Windows.Forms;

namespace Loader;

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
				string caption = "ExileCore2 is already running";
				switch (MessageBox.Show("There are other ExileCore2 instances running already", caption, MessageBoxButtons.AbortRetryIgnore))
				{
				case DialogResult.Retry:
					flag = true;
					break;
				case DialogResult.Ignore:
					return;
				case DialogResult.Abort:
					currentProcess.Kill();
					break;
				}
			}
		}
	}
}
