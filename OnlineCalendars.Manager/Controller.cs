using System;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.PresentationClasses;
using OnlineCalendars.Manager.ToolForms;

namespace OnlineCalendars.Manager
{
	public class Controller
	{
		private static readonly Controller _instance = new Controller();

		private Controller()
		{
			DataManager = new ConfigurationManager();
		}

		public static Controller Instance
		{
			get { return _instance; }
		}

		public ConfigurationManager DataManager { get; private set; }

		public event EventHandler<EventArgs> ConfigurationChanged;

		public Form FormMain { get; set; }
		public SuperTooltip Supertip { get; set; }
		public RibbonControl Ribbon { get; set; }
		public RibbonTabItem TabCalendarEditor { get; set; }
		public RibbonTabItem TabSiteUsers { get; set; }

		public void Init()
		{
			#region Calendars
			CalendarEditor = new CalendarEditorControl();
			CalendarSync.Click += CalendarEditor.Sync;
			CalendarSiteName.EditValueChanged += CalendarEditor.OnEditValueChanged;
			CalendarSiteLogin.EditValueChanged += CalendarEditor.OnEditValueChanged;
			CalendarSitePassword.EditValueChanged += CalendarEditor.OnEditValueChanged;
			#endregion

			#region Site Users
			SiteUsers = new SiteUsersControl();
			#endregion
		}

		public void RemoveInstance()
		{
			CalendarEditor.Dispose();
		}

		public void LoadData()
		{
			CalendarEditor.LoadData(false);
			SiteUsers.LoadData(false);
		}

		public void SaveConfiguration(Configuration localConfiguration, bool quickSave, Control sender)
		{
			using (var form = new FormProgress())
			{
				form.laProgress.Text = "Chill-Out for a few seconds...\nSaving settings...";
				form.TopMost = true;
				var thread = new Thread(() => DataManager.SaveConfiguration(localConfiguration, quickSave, sender));
				form.Show();
				thread.Start();
				while (thread.IsAlive)
					Application.DoEvents();
				form.Close();
			}
			if (ConfigurationChanged != null)
				ConfigurationChanged(this, EventArgs.Empty);
		}

		public void UpdateSiteOptionStatus(bool enabled)
		{
			CalendarSync.Enabled = enabled;
			TabSiteUsers.Enabled = enabled;
		}

		#region Command Controls

		#region Calendar Editor
		public ButtonItem CalendarSync { get; set; }
		public ButtonEdit CalendarSiteName { get; set; }
		public ButtonEdit CalendarSiteLogin { get; set; }
		public ButtonEdit CalendarSitePassword { get; set; }
		#endregion

		#region Site Users
		#endregion

		#endregion

		#region Forms
		public CalendarEditorControl CalendarEditor { get; private set; }
		public SiteUsersControl SiteUsers { get; private set; }
		#endregion
	}
}
