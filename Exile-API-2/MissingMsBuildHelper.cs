// Loader, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Loader.MissingMsBuildHelper
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public static class MissingMsBuildHelper
{
    public static DialogResult ShowDialogBox()
    {
        Form form2 = new Form
        {
            Text = "Missing compiler dependencies",
            FormBorderStyle = FormBorderStyle.FixedDialog,
            StartPosition = FormStartPosition.CenterScreen,
            MinimizeBox = false,
            MaximizeBox = false
        };
        int y1 = 20;
        TextBox textBox2 = new TextBox
        {
            Text = "You need to download the .NET 8 SDK to be able to compile\r\nplugins. If you don't, plugin compilation won't work",
            ReadOnly = true,
            BorderStyle = BorderStyle.None,
            BackColor = form2.BackColor,
            TabStop = false,
            Multiline = true,
            Font = new Font("Microsoft Tai Le", 10f, FontStyle.Regular),
            AutoSize = true
        };
        textBox2.SetBounds(9, y1, 372, 50);
        int y2 = y1 + 50;
        LinkLabel linkLabel2 = new LinkLabel
        {
            Text = "Open the download page (click \"Download .NET SDK\")"
        };
        linkLabel2.Anchor |= AnchorStyles.Right;
        linkLabel2.LinkClicked += delegate
        {
            OpenUrl("https://dotnet.microsoft.com/en-us/download");
        };
        linkLabel2.SetBounds(12, y2, 372, 20);
        int y3 = y2 + 20;
        LinkLabel linkLabel4 = new LinkLabel
        {
            Text = "Sure that you already have the SDK? Try the common issues page"
        };
        linkLabel4.Anchor |= AnchorStyles.Right;
        linkLabel4.LinkClicked += delegate
        {
            OpenUrl("https://github.com/exApiTools/exApiWiki/wiki/Common-.NET-SDK-installation-issues");
        };
        linkLabel4.SetBounds(12, y3, 372, 20);
        int num = y3 + 20;
        Button button2 = new Button
        {
            Text = "Exit",
            DialogResult = DialogResult.Cancel
        };
        Button button4 = new Button
        {
            Text = "Ignore",
            DialogResult = DialogResult.OK
        };
        Button button6 = new Button
        {
            Text = "Don't ask again (will stop trying)",
            BackColor = Color.Red,
            DialogResult = DialogResult.Ignore
        };
        int y4 = num + 20;
        button2.SetBounds(22, y4, 75, 23);
        button4.SetBounds(103, y4, 75, 23);
        button6.SetBounds(184, y4, 200, 23);
        int num2 = y4 + 23;
        button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        form2.ClientSize = new Size(396, num2 + 10);
        form2.Controls.AddRange(new Control[6] { textBox2, button2, button4, button6, linkLabel2, linkLabel4 });
        form2.ClientSize = new Size(Math.Max(300, textBox2.Right + 10), form2.ClientSize.Height);
        form2.AcceptButton = button2;
        form2.CancelButton = button4;
        linkLabel2.Focus();
        return form2.ShowDialog();
    }

    private static void OpenUrl(string url)
    {
        Process.Start(new ProcessStartInfo(url)
        {
            UseShellExecute = true
        });
    }
}
