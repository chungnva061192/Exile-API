using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
	// Token: 0x02000002 RID: 2
	public class AppIcon : IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public AppIcon(CancellationTokenSource cancellationTokenSource)
		{
			this._cancellationTokenSource = cancellationTokenSource;
			Task.Run(delegate()
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				ContextMenuStrip contextMenuStrip = new ContextMenuStrip
				{
					Items = 
					{
						toolStripMenuItem
					}
				};
				toolStripMenuItem.MergeIndex = 0;
				toolStripMenuItem.Text = "E&xit";
                toolStripMenuItem.Click += delegate (object sender, EventArgs e)
                {
					this.Exit();
				};
				Icon icon = Icon.ExtractAssociatedIcon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "textures\\icon.ico"));
				this._notifyIcon = new NotifyIcon
				{
					Visible = true,
					ContextMenuStrip = contextMenuStrip,
					Icon = icon,
					Text = "ExileApi"
				};
				Application.Run();
			});
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002069 File Offset: 0x00000269
		private void Exit()
		{
			this._cancellationTokenSource.Cancel();
			if (this._notifyIcon != null)
			{
				this._notifyIcon.Visible = false;
			}
			Application.Exit();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000208F File Offset: 0x0000028F
		public void Dispose()
		{
			this.Exit();
		}

		// Token: 0x04000001 RID: 1
		private readonly CancellationTokenSource _cancellationTokenSource;

		// Token: 0x04000002 RID: 2
		private NotifyIcon _notifyIcon;
	}
}
