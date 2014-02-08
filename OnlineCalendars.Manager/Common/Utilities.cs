using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OnlineCalendars.Manager.BusinessClasses;

namespace OnlineCalendars.Manager.Common
{
	public class Utilities
	{
		private static readonly Utilities _instance = new Utilities();
		private Utilities() { }
		public static Utilities Instance
		{
			get { return _instance; }
		}

		public void ShowWarning(string text)
		{
			MessageBox.Show(text, SettingsManager.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		public DialogResult ShowWarningQuestion(string text)
		{
			return MessageBox.Show(text, SettingsManager.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
		}

		public void ShowInformation(string text)
		{
			MessageBox.Show(text, SettingsManager.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void ActivateForm(IntPtr handle, bool maximized, bool topMost)
		{
			WinAPIHelper.ShowWindow(handle, maximized ? WindowShowStyle.ShowMaximized : WindowShowStyle.ShowNormal);
			uint lpdwProcessId = 0;
			WinAPIHelper.AttachThreadInput(WinAPIHelper.GetCurrentThreadId(), WinAPIHelper.GetWindowThreadProcessId(WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), true);
			WinAPIHelper.SetForegroundWindow(handle);
			WinAPIHelper.AttachThreadInput(WinAPIHelper.GetCurrentThreadId(), WinAPIHelper.GetWindowThreadProcessId(WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), false);
			if (topMost)
				WinAPIHelper.MakeTopMost(handle);
			else
				WinAPIHelper.MakeNormal(handle);
		}

		public void MinimizeForm(IntPtr handle)
		{
			var form = Control.FromHandle(handle) as Form;
			if (form != null)
				form.WindowState = FormWindowState.Minimized;
		}


		#region Select All in Editor Handlers
		private bool enter;
		private bool needSelect;

		public void Editor_Enter(object sender, EventArgs e)
		{
			enter = true;
		}

		public void Editor_MouseUp(object sender, MouseEventArgs e)
		{
			if (needSelect)
			{
				(sender as BaseEdit).SelectAll();
			}
			ResetEnterFlag();
		}

		public void Editor_MouseDown(object sender, MouseEventArgs e)
		{
			needSelect = enter;
		}

		private void ResetEnterFlag()
		{
			enter = false;
		}
		#endregion

		#region Picture Box Clicks Habdlers
		/// <summary>
		/// Buttonize the PictureBox 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			var pic = (PictureBox)(sender);
			pic.Top += 1;
		}

		public void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			var pic = (PictureBox)(sender);
			pic.Top -= 1;
		}
		#endregion

		#region Internet Browser Support
		private bool _chromeDefinded;
		private bool _firefoxDefinded;
		private bool _operaDefinded;
		private bool _chromeInstalled;
		private bool _firefoxInstalled;
		private bool _operaInstalled;

		public bool ChromeInstalled
		{
			get
			{
				if (!_chromeDefinded)
				{
					try
					{
						var process = new Process
						{
							StartInfo =
							{
								FileName = "chrome.exe",
								CreateNoWindow = true,
								WindowStyle = ProcessWindowStyle.Hidden
							}
						};
						process.Start();
						process.Kill();
						_chromeInstalled = true;
					}
					catch
					{
						_chromeInstalled = false;
					}
					_chromeDefinded = true;
				}
				return _chromeInstalled;
			}
		}

		public bool FirefoxInstalled
		{
			get
			{
				if (!_firefoxDefinded)
				{
					try
					{
						var process = new Process
						{
							StartInfo =
							{
								FileName = "firefox.exe",
								CreateNoWindow = true,
								WindowStyle = ProcessWindowStyle.Hidden
							}
						};
						process.Start();
						process.Kill();
						_firefoxInstalled = true;
					}
					catch
					{
						_firefoxInstalled = false;
					}
					_firefoxDefinded = true;
				}
				return _firefoxInstalled;
			}
		}

		public bool OperaInstalled
		{
			get
			{
				if (!_operaDefinded)
				{
					try
					{
						var process = new Process
						{
							StartInfo =
							{
								FileName = "opera.exe",
								CreateNoWindow = true,
								WindowStyle = ProcessWindowStyle.Hidden
							}
						};
						process.Start();
						process.Kill();
						_operaInstalled = true;
					}
					catch
					{
						_operaInstalled = false;
					}
					_operaDefinded = true;
				}
				return _operaInstalled;
			}
		}
		#endregion
	}
}
