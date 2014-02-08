using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.Common;
using OnlineCalendars.Manager.PresentationClasses.CalendarView;
using OnlineCalendars.Manager.Services;
using OnlineCalendars.Manager.ToolForms;

namespace OnlineCalendars.Manager.PresentationClasses
{
	[ToolboxItem(false)]
	public sealed partial class CalendarEditorControl : UserControl, ITabPageControl
	{
		private Configuration _localConfiguration;

		private readonly List<CalendarViewControl> _calendarViews = new List<CalendarViewControl>();

		public CalendarEditorControl()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
			_calendarViews = new List<CalendarViewControl>();
			Controller.Instance.DataManager.SettingsSaved += (sender, e) => Controller.Instance.FormMain.Invoke((MethodInvoker)delegate
			{
				if (sender != this)
					LoadData(e.QuickSave);
			});

			Controller.Instance.CalendarSiteName.Enter += Utilities.Instance.Editor_Enter;
			Controller.Instance.CalendarSiteName.MouseUp += Utilities.Instance.Editor_MouseUp;
			Controller.Instance.CalendarSiteName.MouseDown += Utilities.Instance.Editor_MouseDown;
			Controller.Instance.CalendarSiteLogin.Enter += Utilities.Instance.Editor_Enter;
			Controller.Instance.CalendarSiteLogin.MouseUp += Utilities.Instance.Editor_MouseUp;
			Controller.Instance.CalendarSiteLogin.MouseDown += Utilities.Instance.Editor_MouseDown;
			Controller.Instance.CalendarSitePassword.Enter += Utilities.Instance.Editor_Enter;
			Controller.Instance.CalendarSitePassword.MouseUp += Utilities.Instance.Editor_MouseUp;
			Controller.Instance.CalendarSitePassword.MouseDown += Utilities.Instance.Editor_MouseDown;
		}

		public bool SettingsNotSaved { get; set; }

		public void LoadData(bool quickLoad)
		{
			_localConfiguration = Controller.Instance.DataManager.GetLocalConfiguration();
			_calendarViews.ForEach(cv => cv.UpdateData(_localConfiguration.Calendars.FirstOrDefault(c => c.Id.Equals(cv.Calendar.Id))));
			calendarListControl.ConfigurationChanged += OnConfigurationChanged;
			calendarListControl.CalendarChanged += OnCalendarChanged;
			calendarListControl.LoadData(_localConfiguration);
			OnCalendarChanged(this, EventArgs.Empty);

			Controller.Instance.CalendarSiteName.EditValue = _localConfiguration.Site;
			Controller.Instance.CalendarSiteLogin.EditValue = _localConfiguration.Login;
			Controller.Instance.CalendarSitePassword.EditValue = _localConfiguration.Password;

			Controller.Instance.UpdateSiteOptionStatus(_localConfiguration.IsConfigured);

			SettingsNotSaved = false;
		}

		public void SaveData(string fileName = "")
		{
			if (!SettingsNotSaved) return;

			_localConfiguration.Site = Controller.Instance.CalendarSiteName.EditValue as String;
			_localConfiguration.Login = Controller.Instance.CalendarSiteLogin.EditValue as String;
			_localConfiguration.Password = Controller.Instance.CalendarSitePassword.EditValue as String;

			Controller.Instance.SaveConfiguration(_localConfiguration, true, this);
			SettingsNotSaved = false;
		}

		private void OnConfigurationChanged(object sender, ConfigurationChangeEventArgs e)
		{
			SettingsNotSaved = true;

			if (!e.ChangedCalendarIds.Any()) return;
			foreach (var calendarId in e.ChangedCalendarIds)
			{
				var calendarView = _calendarViews.FirstOrDefault(cv => cv.Calendar.Id.Equals(calendarId));
				if (calendarView == null) continue;
				_calendarViews.Remove(calendarView);
				splitContainerControl.Panel2.Controls.Remove(calendarView);
			}
			OnCalendarChanged(sender, e);
		}

		private void OnCalendarChanged(object sender, EventArgs e)
		{
			_calendarViews.ForEach(cv => cv.Visible = false);
			var calendar = _localConfiguration.Calendars.FirstOrDefault(c => c.Id.Equals(Guid.Parse(SettingsManager.Instance.LastSelectedCalendarId)));
			if (calendar == null) return;
			var calendarView = _calendarViews.FirstOrDefault(cv => cv.Calendar.Id.Equals(calendar.Id));
			if (calendarView == null)
			{
				pnEmpty.BringToFront();
				calendarView = new CalendarViewControl(calendar);
				calendarView.DataChanged += (o, args) => { SettingsNotSaved = true; };
				calendarView.Visible = false;
				_calendarViews.Add(calendarView);
				splitContainerControl.Panel2.Controls.Add(calendarView);
				pnEmpty.SendToBack();
			}
			calendarView.Visible = true;
			calendarView.BringToFront();
		}

		public void OnEditValueChanged(object sender, EventArgs e)
		{
			Controller.Instance.UpdateSiteOptionStatus(!String.IsNullOrEmpty(Controller.Instance.CalendarSiteName.EditValue as String) &&
				!String.IsNullOrEmpty(Controller.Instance.CalendarSiteLogin.EditValue as String) &&
				!String.IsNullOrEmpty(Controller.Instance.CalendarSitePassword.EditValue as String));

			SettingsNotSaved = true;
		}

		public void Sync(object sender, EventArgs e)
		{
			SaveData();
			var message = String.Empty;
			using (var form = new FormProgress())
			{
				form.laProgress.Text = "Chill-Out for a few seconds...\nExporting calendars...";
				form.TopMost = true;
				var thread = new Thread(() => new SyncHelper(_localConfiguration).Sync(out message));
				form.Show();
				thread.Start();
				while (thread.IsAlive)
					Application.DoEvents();
				form.Close();
			}
			if (String.IsNullOrEmpty(message))
				Utilities.Instance.ShowInformation("Calendars successfully exported");
			else
				Utilities.Instance.ShowWarning(String.Format("Error occured while exporting:{0}{1}", Environment.NewLine, message));
		}
	}
}
