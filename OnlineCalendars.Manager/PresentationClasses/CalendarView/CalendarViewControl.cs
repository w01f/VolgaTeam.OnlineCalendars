using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.ToolForms;

namespace OnlineCalendars.Manager.PresentationClasses.CalendarView
{
	[ToolboxItem(false)]
	public partial class CalendarViewControl : UserControl
	{
		private readonly List<DayControl> _days = new List<DayControl>();

		public Calendar Calendar { get; private set; }
		public List<MonthControl> Months { get; private set; }
		public SelectionManager SelectionManager { get; private set; }
		public CopyPasteManager CopyPasteManager { get; private set; }

		public event EventHandler<EventArgs> DataChanged;

		public CalendarViewControl(Calendar calendar)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
			Calendar = calendar;
			Months = new List<MonthControl>();
			SelectionManager = new SelectionManager(this);

			#region Copy-Paster Initialization
			CopyPasteManager = new CopyPasteManager();
			CopyPasteManager.DayPasted += (sender, e) =>
			{
				foreach (var month in Months)
					month.RefreshData(Calendar.SlideColorLight, Calendar.SlideColorDark);
				if (DataChanged != null)
					DataChanged(this, EventArgs.Empty);
			};
			#endregion

			#region Data
			foreach (var monthData in Calendar.Months.OrderBy(m => m.Date))
			{
				var month = new MonthControlSundayBased(monthData.Date);
				Months.Add(month);
			}
			xtraTabControl.TabPages.AddRange(Months.ToArray());
			MonthChanged(xtraTabControl, new TabPageChangingEventArgs(null, Months.FirstOrDefault()));
			xtraTabControl.SelectedPageChanging += MonthChanged;
			#endregion

			DataChanged += OnDataChanged;
		}

		private void OnDataChanged(object sender, EventArgs e)
		{
			Calendar.LastModified = DateTime.Now;
		}

		public void UpdateData(Calendar calendar)
		{
			Calendar = calendar;
			foreach (var day in _days)
				day.Day = calendar.Days.FirstOrDefault(d => d.Date.Date == day.Day.Date.Date);
		}

		private void MonthChanged(object pageControl, TabPageChangingEventArgs eventArgs)
		{
			SelectionManager.ClearSelection();
			CopyPasteManager.ResetCopy();
			foreach (var existedMonth in Months)
				existedMonth.RaiseEvents(false);

			var month = eventArgs.Page as MonthControl;
			if (month == null) return;
			if (!month.HasData)
			{
				var calendarMonth = Calendar.Months.FirstOrDefault(d => d.Date.Equals(month.Date));
				using (var form = new FormProgress())
				{
					form.laProgress.Text = "Chill-Out for a few seconds...\nLoading month data...";
					form.TopMost = true;
					var thread = new Thread(() => Controller.Instance.FormMain.Invoke((MethodInvoker) delegate
					{
						var weeks = new List<DayControl[]>();
						var datesByWeeks = Calendar.GetDaysByWeek(calendarMonth.DaysRangeBegin, calendarMonth.DaysRangeEnd);
						foreach (var weekDays in datesByWeeks)
						{
							var week = new List<DayControl>();
							foreach (var calendarDay in weekDays.Select(weekDay => Calendar.Days.FirstOrDefault(d => d.Date.Equals(weekDay))))
							{
								if (calendarDay != null)
								{
									var dayControl = new DayControl(calendarDay);
									dayControl.DaySelected += (sender, e) =>
									{
										SelectionManager.SelectDay(e.SelectedDay.Day, e.ModifierKeys);
										CopyPasteManager.SetCopyDay();
									};
									dayControl.DayCopied += (sender, e) => CopyDay();
									dayControl.DayPasted += (sender, e) => PasteDay();
									dayControl.DayCloned += (sender, e) => CloneDay();
									dayControl.DayDataDeleted += (sender, e) =>
									{
										foreach (var day in SelectionManager.SelectedDays)
										{
											day.ClearData();
										}
										if (DataChanged != null)
											DataChanged(this, EventArgs.Empty);
									};
									dayControl.DataChanged += (sender, e) =>
									{
										if (DataChanged != null)
											DataChanged(this, EventArgs.Empty);
									};

									dayControl.SelectionStateRequested += (sender, e) => SelectionManager.ProcessSelectionStateRequest();
									dayControl.DayMouseMove += (sender, e) =>
									{
										foreach (var day in _days)
											if (day.Day.BelongsToSchedules && day.ClientRectangle.Contains(day.PointToClient(Cursor.Position)) && day.RaiseEvents)
												SelectionManager.SelectDay(day.Day, Keys.Control);
									};

									CopyPasteManager.OnSetCopyDay += (sender, e) =>
									{
										dayControl.toolStripMenuItemCopy.Enabled = true;
										dayControl.toolStripMenuItemClone.Enabled = true;
									};
									CopyPasteManager.OnResetCopy += (sender, e) =>
									{
										dayControl.toolStripMenuItemCopy.Enabled = false;
										dayControl.toolStripMenuItemClone.Enabled = false;
										dayControl.ChangeCopySource(false);
									};
									CopyPasteManager.OnResetPaste += (sender, e) =>
									{
										dayControl.toolStripMenuItemPaste.Enabled = false;
									};
									CopyPasteManager.DayCopied += (sender, e) =>
									{
										dayControl.toolStripMenuItemPaste.Enabled = true;
										dayControl.ChangeCopySource(dayControl.Day.Date.Equals(CopyPasteManager.SourceDay.Date));
									};
									AssignCloseActiveEditorsonOutSideClick(dayControl);
									week.Add(dayControl);
									_days.Add(dayControl);
								}
								Application.DoEvents();
							}
							weeks.Add(week.ToArray());
							Application.DoEvents();
						}
						month.AddDays(weeks.ToArray());
					}));

					form.Show();
					Application.DoEvents();

					thread.Start();

					while (thread.IsAlive)
						Application.DoEvents();
					form.Close();
				}
				month.RefreshData(Calendar.SlideColorLight, Calendar.SlideColorDark);
			}
			month.RaiseEvents(true);
		}

		public void SelectDay(CalendarDay day, bool selected)
		{
			var dayControl = _days.FirstOrDefault(x => x.Day.Date.Equals(day.Date));
			if (dayControl != null)
				dayControl.ChangeSelection(selected);
		}

		#region Copy-Paste Methods and Event Handlers
		public void CopyDay()
		{
			var selectedDay = SelectionManager.SelectedDays.FirstOrDefault();
			if (selectedDay != null)
				CopyPasteManager.CopyDay(selectedDay);
		}

		public void PasteDay()
		{
			var selectedDays = SelectionManager.SelectedDays.ToArray();
			if (selectedDays != null)
				CopyPasteManager.PasteDay(selectedDays);
		}

		public void CloneDay()
		{
			CalendarDay[] clonedDays = null;
			var selectedDay = SelectionManager.SelectedDays.FirstOrDefault();
			if (selectedDay == null) return;
			using (var form = new FormCloneDay(selectedDay, Calendar.DateStart.Value, Calendar.DateEnd.Value))
			{
				if (form.ShowDialog() == DialogResult.OK)
					clonedDays = Calendar.Days.Where(x => form.SelectedDates.Contains(x.Date)).ToArray();
			}
			if (clonedDays != null)
				CopyPasteManager.CloneDay(selectedDay, clonedDays);
		}
		#endregion

		private void AssignCloseActiveEditorsonOutSideClick(Control control)
		{
			if (control.GetType() == typeof(TextEdit) || control.GetType() == typeof(MemoEdit) || control.GetType() == typeof(ComboBoxEdit) || control.GetType() == typeof(LookUpEdit) || control.GetType() == typeof(DateEdit) || control.GetType() == typeof(CheckedListBoxControl) || control.GetType() == typeof(SpinEdit) || control.GetType() == typeof(CheckEdit) || control.GetType() == typeof(ImageListBoxControl)) return;
			control.Click += CloseActiveEditorsonOutSideClick;
			foreach (Control childControl in control.Controls)
				AssignCloseActiveEditorsonOutSideClick(childControl);
		}

		private void CloseActiveEditorsonOutSideClick(object sender, EventArgs e)
		{
			Controller.Instance.Ribbon.Focus();
		}
	}
}
