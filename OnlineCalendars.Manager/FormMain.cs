using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.Common;
using OnlineCalendars.Manager.PresentationClasses;
using OnlineCalendars.Manager.ToolForms;

namespace OnlineCalendars.Manager
{
	public partial class FormMain : Form
	{
		private static FormMain _instance;
		private ITabPageControl _currentControl;

		private FormMain()
		{
			InitializeComponent();

			Controller.Instance.FormMain = this;
			Controller.Instance.Supertip = superTooltip;
			Controller.Instance.Ribbon = ribbonControl;
			Controller.Instance.TabCalendarEditor = ribbonTabItemCalendarEditor;
			Controller.Instance.TabSiteUsers = ribbonTabItemSiteUsers;

			#region Command Controls

			#region Calendar Editor
			Controller.Instance.CalendarSync = buttonItemCalendarSync;
			Controller.Instance.CalendarSiteName = buttonEditCalendarSiteName;
			Controller.Instance.CalendarSiteLogin = buttonEditCalendarSiteLogin;
			Controller.Instance.CalendarSitePassword = buttonEditCalendarSitePassword;
			#endregion

			#region Site Users
			#endregion

			#endregion

			Controller.Instance.Init();

			Controller.Instance.ConfigurationChanged += (o, e) => UpdateFormTitle();

			if ((CreateGraphics()).DpiX > 96)
			{
				var font = new Font(styleController.Appearance.Font.FontFamily, styleController.Appearance.Font.Size - 1, styleController.Appearance.Font.Style);
				ribbonControl.Font = font;
				styleController.Appearance.Font = font;
				styleController.AppearanceDisabled.Font = font;
				styleController.AppearanceDropDown.Font = font;
				styleController.AppearanceDropDownHeader.Font = font;
				styleController.AppearanceFocused.Font = font;
				styleController.AppearanceReadOnly.Font = font;
			}
		}

		public static FormMain Instance
		{
			get { return _instance ?? (_instance = new FormMain()); }
		}

		public static void RemoveInstance()
		{
			_instance.Dispose();
			_instance = null;
		}

		private void UpdateFormTitle()
		{
			var configuration = Controller.Instance.DataManager.ConfigurationLoaded ? Controller.Instance.DataManager.GetShortConfiguration() : null;
			Text = String.Format("{0} - {1}", SettingsManager.ApplicationName, configuration != null ? configuration.ShortFileName : "Not selected");
		}

		private void LoadData()
		{
			UpdateFormTitle();
			ribbonControl.Enabled = false;
			using (var form = new FormProgress())
			{
				form.laProgress.Text = "Chill-Out for a few seconds...\nLoading Calendar Configuration...";
				form.TopMost = true;
				form.Show();
				var thread = new Thread(() => Invoke((MethodInvoker)(() => Controller.Instance.LoadData())));
				thread.Start();
				while (thread.IsAlive)
					Application.DoEvents();
				form.Close();
			}
			ribbonControl.SelectedRibbonTabChanged -= ribbonControl_SelectedRibbonTabChanged;
			ribbonControl.SelectedRibbonTabItem = ribbonTabItemCalendarEditor;
			ribbonControl_SelectedRibbonTabChanged(null, null);
			ribbonControl.SelectedRibbonTabChanged += ribbonControl_SelectedRibbonTabChanged;
			ribbonControl.Enabled = true;
		}

		private void SaveData()
		{
			if (_currentControl == null) return;
			_currentControl.SaveData();
		}

		private void OpenConfiguration(string configurationName)
		{
			Controller.Instance.DataManager.OpenConfiguration(configurationName, false);
			if (Controller.Instance.DataManager.ConfigurationLoaded)
				LoadData();
		}

		private void FormMain_Shown(object sender, EventArgs e)
		{
			UpdateFormTitle();
			if (File.Exists(SettingsManager.Instance.IconPath))
				Icon = new Icon(SettingsManager.Instance.IconPath);

			AppManager.Instance.ActivateMainForm();

			if (!String.IsNullOrEmpty(SettingsManager.Instance.LastOpenConfiguration))
				OpenConfiguration(SettingsManager.Instance.LastOpenConfiguration);

			if (Controller.Instance.DataManager.ConfigurationLoaded) return;
			using (var formStart = new FormStart())
			{
				formStart.simpleButtonOpen.Enabled = ConfigurationManager.GetShortConfigurationList().Any();
				var result = formStart.ShowDialog();
				if (result == DialogResult.Yes || result == DialogResult.No)
				{
					if (result == DialogResult.Yes)
						buttonItemHomeNewSchedule_Click(null, null);
					else
						buttonItemHomeOpenSchedule_Click(null, null);
				}
				else
					Application.Exit();
			}
		}

		private void ribbonControl_SelectedRibbonTabChanged(object sender, EventArgs e)
		{
			if (_currentControl != null)
				_currentControl.SaveData();
			if (ribbonControl.SelectedRibbonTabItem == ribbonTabItemCalendarEditor)
			{
				_currentControl = Controller.Instance.CalendarEditor;
			}
			else if (ribbonControl.SelectedRibbonTabItem == ribbonTabItemSiteUsers)
			{
				_currentControl = Controller.Instance.SiteUsers;
			}
			if (!pnMain.Controls.Contains((Control) _currentControl))
			{
				pnEmpty.BringToFront();
				pnMain.Controls.Add((UserControl) _currentControl);
				pnMain.BringToFront();
			}
			((UserControl)_currentControl).BringToFront();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
		}

		private void buttonItemHomeNewSchedule_Click(object sender, EventArgs e)
		{
			SaveData();
			using (var from = new FormNewSchedule())
			{
				if (from.ShowDialog() == DialogResult.OK)
				{
					if (!string.IsNullOrEmpty(from.ScheduleName))
					{
						var fileName = from.ScheduleName.Trim();
						Controller.Instance.DataManager.CreateConfiguration(fileName);
						LoadData();
					}
					else
						Utilities.Instance.ShowWarning("Schedule Name can't be empty");
				}
				else if (!Controller.Instance.DataManager.ConfigurationLoaded)
					Close();
			}
		}

		private void buttonItemHomeOpenSchedule_Click(object sender, EventArgs e)
		{
			SaveData();
			using (var from = new FormOpenSchedule())
			{
				if (from.ShowDialog() == DialogResult.OK)
				{
					var fileName = from.ScheduleName.Trim();
					OpenConfiguration(fileName);
				}
				if (!Controller.Instance.DataManager.ConfigurationLoaded)
					Close();
			}
		}

		private void buttonItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
