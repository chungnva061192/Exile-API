using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Loader
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002D30 File Offset: 0x00000F30
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

		// Token: 0x06000026 RID: 38 RVA: 0x00002D64 File Offset: 0x00000F64
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
