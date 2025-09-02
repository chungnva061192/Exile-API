using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Loader;

public class MissingMsBuildHelper
{
	public static DialogResult ShowDialogBox()
	{
		Form form = new Form
		{
			Text = "Missing compiler dependencies",
			FormBorderStyle = FormBorderStyle.FixedDialog,
			StartPosition = FormStartPosition.CenterScreen,
			MinimizeBox = false,
			MaximizeBox = false
		};
		int num = 20;
		TextBox textBox = new TextBox
		{
			Text = "You need to download the .NET 8 SDK to be able to compile\r\nplugins. If you don't, plugin compilation won't work",
			ReadOnly = true,
			BorderStyle = BorderStyle.None,
			BackColor = form.BackColor,
			TabStop = false,
			Multiline = true,
			Font = new Font("Microsoft Tai Le", 10f, FontStyle.Regular),
			AutoSize = true
		};
		textBox.SetBounds(9, num, 372, 50);
		num += 50;
		LinkLabel linkLabel = new LinkLabel
		{
			Text = "Open the download page (click \"Download .NET SDK\")"
		};
		linkLabel.Anchor |= AnchorStyles.Right;
		linkLabel.LinkClicked += delegate
		{
			OpenUrl("https://dotnet.microsoft.com/en-us/download");
		};
		linkLabel.SetBounds(12, num, 372, 20);
		num += 20;
		LinkLabel linkLabel2 = new LinkLabel
		{
			Text = "Sure that you already have the SDK? Try the common issues page"
		};
		linkLabel2.Anchor |= AnchorStyles.Right;
		linkLabel2.LinkClicked += delegate
		{
			OpenUrl("https://github.com/exApiTools/exApiWiki/wiki/Common-.NET-SDK-installation-issues");
		};
		linkLabel2.SetBounds(12, num, 372, 20);
		num += 20;
		Button button = new Button
		{
			Text = "Exit",
			DialogResult = DialogResult.Cancel
		};
		Button button2 = new Button
		{
			Text = "Ignore",
			DialogResult = DialogResult.OK
		};
		Button button3 = new Button
		{
			Text = "Don't ask again (will stop trying)",
			BackColor = Color.Red,
			DialogResult = DialogResult.Ignore
		};
		num += 20;
		button.SetBounds(22, num, 75, 23);
		button2.SetBounds(103, num, 75, 23);
		button3.SetBounds(184, num, 200, 23);
		num += 23;
		button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		form.ClientSize = new Size(396, num + 10);
		form.Controls.AddRange(new Control[6] { textBox, button, button2, button3, linkLabel, linkLabel2 });
		form.ClientSize = new Size(Math.Max(300, textBox.Right + 10), form.ClientSize.Height);
		form.AcceptButton = button;
		form.CancelButton = button2;
		linkLabel.Focus();
		return form.ShowDialog();
	}

	private static void OpenUrl(string url)
	{
		Process.Start(new ProcessStartInfo(url)
		{
			UseShellExecute = true
		});
	}
}
