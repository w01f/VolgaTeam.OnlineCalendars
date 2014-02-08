using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.Common;

namespace OnlineCalendars.Manager.PresentationClasses.CalendarList
{
	public partial class CalendarListControl : UserControl
	{
		private bool _dataLoading;

		private Configuration _selectedConfiguration;
		public event EventHandler<ConfigurationChangeEventArgs> ConfigurationChanged;
		public event EventHandler<EventArgs> CalendarChanged;

		public Calendar SelectedCalendar
		{
			get { return gridViewList.GetFocusedRow() as Calendar; }
		}

		public CalendarListControl()
		{
			InitializeComponent();
			ConfigurationChanged += OnConfigurationChanged;
		}

		private void OnConfigurationChanged(object sender, EventArgs e)
		{
			barButtonItemEdit.Enabled =
			barButtonItemClone.Enabled =
			barButtonItemDelete.Enabled =
				SelectedCalendar != null;
		}

		public void LoadData(Configuration selectedConfiguration)
		{
			_dataLoading = true;
			_selectedConfiguration = selectedConfiguration;
			gridControlList.DataSource = _selectedConfiguration.Calendars;

			if (!String.IsNullOrEmpty(SettingsManager.Instance.LastSelectedCalendarId) && _selectedConfiguration.Calendars.Any())
			{
				var selectedCalendar = _selectedConfiguration.Calendars.FirstOrDefault(c => c.Id.Equals(Guid.Parse(SettingsManager.Instance.LastSelectedCalendarId))) ?? _selectedConfiguration.Calendars.FirstOrDefault();
				var focussedRowHandle = selectedCalendar != null ? _selectedConfiguration.Calendars.IndexOf(selectedCalendar) : GridControl.InvalidRowHandle;
				gridViewList.FocusedRowHandle = focussedRowHandle;
			}

			OnConfigurationChanged(this, EventArgs.Empty);

			gridViewList.RefreshData();

			_dataLoading = false;
		}

		private void gridViewList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (_dataLoading) return;

			SettingsManager.Instance.LastSelectedCalendarId = SelectedCalendar != null ? SelectedCalendar.Id.ToString() : null;
			SettingsManager.Instance.SaveSettings();

			if (CalendarChanged != null)
				CalendarChanged(this, EventArgs.Empty);
		}

		private void gridViewList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (e.Clicks == 2)
				barButtonItemEdit_ItemClick(barButtonItemEdit, new ItemClickEventArgs(barButtonItemEdit, barButtonItemEdit.Links[0]));
		}

		private void barButtonItemAdd_ItemClick(object sender, ItemClickEventArgs e)
		{
			using (var form = new FormCalendarNew())
			{
				if (form.ShowDialog() != DialogResult.OK) return;
				var newCalendar = new Calendar
				{
					Name = form.CalendarName,
					DateStart = form.CalendarStart,
					DateEnd = form.CalendarEnd
				};
				newCalendar.UpdateDaysCollection();
				newCalendar.UpdateMonthCollection();
				_selectedConfiguration.Calendars.Add(newCalendar);

				SettingsManager.Instance.LastSelectedCalendarId = newCalendar.Id.ToString();
				SettingsManager.Instance.SaveSettings();

				LoadData(_selectedConfiguration);

				if (ConfigurationChanged != null)
					ConfigurationChanged(this, new ConfigurationChangeEventArgs());

				if (CalendarChanged != null)
					CalendarChanged(this, EventArgs.Empty);
			}
		}

		private void barButtonItemEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (SelectedCalendar == null) return;
			using (var form = new FormCalendarEdit())
			{
				form.CalendarName = SelectedCalendar.Name;
				form.CalendarStart = SelectedCalendar.DateStart;
				form.CalendarEnd = SelectedCalendar.DateEnd;
				if (form.ShowDialog() != DialogResult.OK) return;
				SelectedCalendar.Name = form.CalendarName;
				var calendarChanged = SelectedCalendar.DateStart != form.CalendarStart || SelectedCalendar.DateEnd != form.CalendarEnd;
				if (calendarChanged)
				{
					SelectedCalendar.DateStart = form.CalendarStart;
					SelectedCalendar.DateEnd = form.CalendarEnd;
					SelectedCalendar.UpdateDaysCollection();
					SelectedCalendar.UpdateMonthCollection();
					SelectedCalendar.LastModified = DateTime.Now;
				}
				gridViewList.UpdateCurrentRow();
				
				var eventArgs = new ConfigurationChangeEventArgs();
				eventArgs.ChangedCalendarIds.Add(SelectedCalendar.Id);
				if (ConfigurationChanged != null)
					ConfigurationChanged(this, eventArgs);
			}
		}

		private void barButtonItemClone_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (SelectedCalendar == null) return;
			using (var form = new FormCalendarClone())
			{
				var newCalendar = SelectedCalendar.Clone();
				form.CalendarName = String.Format("Clone of {0}", newCalendar.Name);
				form.CalendarStart = newCalendar.DateStart;
				form.CalendarEnd = newCalendar.DateEnd;
				if (form.ShowDialog() != DialogResult.OK) return;
				newCalendar.Name = form.CalendarName;
				newCalendar.DateStart = form.CalendarStart;
				newCalendar.DateEnd = form.CalendarEnd;
				newCalendar.UpdateDaysCollection();
				newCalendar.UpdateMonthCollection();
				_selectedConfiguration.Calendars.Add(newCalendar);

				SettingsManager.Instance.LastSelectedCalendarId = newCalendar.Id.ToString();
				SettingsManager.Instance.SaveSettings();

				LoadData(_selectedConfiguration);

				if (ConfigurationChanged != null)
					ConfigurationChanged(this, new ConfigurationChangeEventArgs());

				if (CalendarChanged != null)
					CalendarChanged(this, EventArgs.Empty);
			}
		}

		private void barButtonItemDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (SelectedCalendar == null) return;
			if (Utilities.Instance.ShowWarningQuestion("Do you want to remove selected calendar?") == DialogResult.Yes)
			{
				gridViewList.DeleteRow(gridViewList.FocusedRowHandle);

				LoadData(_selectedConfiguration);

				if (ConfigurationChanged != null)
					ConfigurationChanged(this, new ConfigurationChangeEventArgs());
			}
		}

		private void barButtonItemHelp_ItemClick(object sender, ItemClickEventArgs e)
		{

		}
	}
}
