// Loader, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Loader.AppIcon
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public class AppIcon : IDisposable
{
    private readonly CancellationTokenSource _cancellationTokenSource;

    private NotifyIcon _notifyIcon;

    public AppIcon(CancellationTokenSource cancellationTokenSource)
    {
        _cancellationTokenSource = cancellationTokenSource;
        Task.Run(delegate
        {
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip
            {
                Items = { (ToolStripItem)toolStripMenuItem }
            };
            toolStripMenuItem.MergeIndex = 0;
            toolStripMenuItem.Text = "E&xit";
            toolStripMenuItem.Click += delegate
            {
                Exit();
            };
            Icon icon = Icon.ExtractAssociatedIcon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "textures\\icon.ico"));
            _notifyIcon = new NotifyIcon
            {
                Visible = true,
                ContextMenuStrip = contextMenuStrip,
                Icon = icon,
                Text = "ExileApi"
            };
            Application.Run();
        });
    }

    private void Exit()
    {
        _cancellationTokenSource.Cancel();
        if (_notifyIcon != null)
        {
            _notifyIcon.Visible = false;
        }
        Application.Exit();
    }

    public void Dispose()
    {
        Exit();
    }
}
