using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.Common;
using Pabo.Calendar;

namespace OnlineCalendars.Manager.PresentationClasses.CalendarView
{
	public partial class FormCloneDay : Form
	{
		private readonly CalendarDay _day;
		private readonly DateTime _flightDateEnd;
		private readonly DateTime _flightDateStart;
		private readonly List<DateItem> _selectedDates = new List<DateItem>();

		public FormCloneDay(CalendarDay day, DateTime flightDateStart, DateTime flightDateEnd)
		{
			InitializeComponent();
			_day = day;
			_flightDateStart = flightDateStart;
			_flightDateEnd = flightDateEnd;
			labelControlFlightDates.Text = string.Format(labelControlFlightDates.Text, string.Format("{0} - {1}", new object[] { _flightDateStart.ToString("M/d/yy"), _flightDateEnd.ToString("M/d/yy") }));
			laOriginalDate.Text = _day.Date.ToString(@"dddd, MM/dd/yy");
			checkEditHighlightWeekdays.Text = string.Format(checkEditHighlightWeekdays.Text, _day.Date.ToString("dddd"));
			buttonXAddAllWeekdays.Text = string.Format(buttonXAddAllWeekdays.Text, _day.Date.ToString("dddd"));
			monthCalendarClone.ActiveMonth.Month = _day.Date.Month;
			monthCalendarClone.ActiveMonth.Year = _day.Date.Year;
			monthCalendarClone.Header.TextColor = Color.Black;
			xtraTabControlClone.ShowTabHeader = DefaultBoolean.False;

			UpdateTotals();

			if ((base.CreateGraphics()).DpiX > 96)
			{
				laOriginalDate.Font = new Font(laOriginalDate.Font.FontFamily, laOriginalDate.Font.Size - 4, laOriginalDate.Font.Style);
				labelControlDayTitle.Font = new Font(labelControlDayTitle.Font.FontFamily, labelControlDayTitle.Font.Size - 2, labelControlDayTitle.Font.Style);
				labelControlFlightDates.Font = new Font(labelControlFlightDates.Font.FontFamily, labelControlFlightDates.Font.Size - 2, labelControlFlightDates.Font.Style);
				labelControlClonedNumber.Font = new Font(labelControlClonedNumber.Font.FontFamily, labelControlClonedNumber.Font.Size - 2, labelControlClonedNumber.Font.Style);
				checkEditHighlightWeekdays.Font = new Font(checkEditHighlightWeekdays.Font.FontFamily, checkEditHighlightWeekdays.Font.Size - 2, checkEditHighlightWeekdays.Font.Style);
				buttonXCancel.Font = new Font(buttonXCancel.Font.FontFamily, buttonXCancel.Font.Size - 2, buttonXCancel.Font.Style);
				buttonXAddAllWeekdays.Font = new Font(buttonXAddAllWeekdays.Font.FontFamily, buttonXAddAllWeekdays.Font.Size - 2, buttonXAddAllWeekdays.Font.Style);
				buttonXClearAll.Font = new Font(buttonXClearAll.Font.FontFamily, buttonXClearAll.Font.Size - 2, buttonXClearAll.Font.Style);
				buttonXOK.Font = new Font(buttonXOK.Font.FontFamily, buttonXOK.Font.Size - 2, buttonXOK.Font.Style);
			}
		}

		public DateTime[] SelectedDates
		{
			get { return _selectedDates.Select(x => x.Date).ToArray(); }
		}

		private void UpdateSelectedDates()
		{
			gridControlDays.DataSource = new BindingList<DateItem>(_selectedDates.ToArray());
			monthCalendarClone.Refresh();
			UpdateTotals();
		}

		private void UpdateTotals()
		{
			labelControlClonedNumber.Text = string.Format("Cloned Days: <b>{0}</b>", _selectedDates.Count.ToString());
		}

		private void AddSelectedDate(DateTime selectedDate)
		{
			var dateItem = new DateItem();
			dateItem.Date = selectedDate;
			dateItem.BackColor1 = Color.Blue;
			if (!_selectedDates.Select(x => x.Date).Contains(selectedDate))
				_selectedDates.Add(dateItem);
			UpdateSelectedDates();
		}

		private void repositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			_selectedDates.RemoveAt(gridViewDays.GetDataSourceRowIndex(gridViewDays.FocusedRowHandle));
			UpdateSelectedDates();
		}

		private void monthCalendarClone_DayQueryInfo(object sender, DayQueryInfoEventArgs e)
		{
			if (_selectedDates.Select(x => x.Date).Contains(e.Date))
			{
				e.Info.BackColor1 = Color.Blue;
				e.Info.TextColor = Color.White;
				e.Info.DateColor = Color.White;
				e.OwnerDraw = true;
			}
			else if (e.Date == _day.Date)
			{
				e.Info.BackColor1 = Color.Green;
				e.Info.TextColor = Color.White;
				e.Info.DateColor = Color.White;
				e.OwnerDraw = true;
			}
			else if (e.Date.DayOfWeek == _day.Date.DayOfWeek && checkEditHighlightWeekdays.Checked && (e.Date >= _flightDateStart && e.Date <= _flightDateEnd))
			{
				e.Info.BoldedDate = true;
				e.OwnerDraw = true;
			}
			else if (!(e.Date >= _flightDateStart && e.Date <= _flightDateEnd))
			{
				e.Info.TextColor = Color.Gray;
				e.Info.DateColor = Color.Gray;
				e.OwnerDraw = true;
				e.OwnerDraw = true;
			}
		}

		private void buttonXClearAll_Click(object sender, EventArgs e)
		{
			_selectedDates.Clear();
			UpdateSelectedDates();
		}

		private void buttonXAddAllWeekdays_Click(object sender, EventArgs e)
		{
			var startDate = _flightDateStart;
			while (!startDate.DayOfWeek.Equals(_day.Date.DayOfWeek))
				startDate = startDate.AddDays(1);
			while (startDate <= _flightDateEnd)
			{
				if (startDate != _day.Date)
					AddSelectedDate(startDate.Date);
				startDate = startDate.AddDays(7);
			}
		}

		private void buttonXSelectAllDays_Click(object sender, EventArgs e)
		{
			var startDate = _flightDateStart;
			while (startDate <= _flightDateEnd)
			{
				if (startDate != _day.Date)
					AddSelectedDate(startDate.Date);
				startDate = startDate.AddDays(1);
			}
		}

		private void buttonXSelectFirstDays_Click(object sender, EventArgs e)
		{
			var startDate = _flightDateStart;
			while (startDate <= _flightDateEnd)
			{
				if (startDate != _day.Date && (startDate.Day == 1 || startDate.Equals(_flightDateStart)))
					AddSelectedDate(startDate.Date);
				startDate = startDate.AddDays(1);
			}
		}

		private void checkEditHighlightWeekdays_CheckedChanged(object sender, EventArgs e)
		{
			monthCalendarClone.Refresh();
		}

		private void monthCalendarClone_DayClick(object sender, DayClickEventArgs e)
		{
			DateTime temp;
			if (!DateTime.TryParse(e.Date, out temp)) return;
			if (temp >= _flightDateStart && temp <= _flightDateEnd)
				AddSelectedDate(temp);
			else if (temp < _flightDateStart || temp > _flightDateEnd)
				Utilities.Instance.ShowWarning("Pick a date that is in your Schedule Window…");
		}

		private void pbHelp_Click(object sender, EventArgs e)
		{
			//BusinessWrapper.Instance.HelpManager.OpenHelpLink("ninjaclone");
		}

		#region Picture Box Clicks Habdlers
		/// <summary>
		/// Buttonize the PictureBox 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			var pic = (PictureBox)(sender);
			pic.Top += 1;
		}

		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			var pic = (PictureBox)(sender);
			pic.Top -= 1;
		}
		#endregion
	}
}