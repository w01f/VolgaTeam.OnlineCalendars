using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OnlineCalendars.Manager.PresentationClasses.CalendarView;

namespace OnlineCalendars.Manager.BusinessClasses
{
	public class SelectionManager
	{
		public SelectionManager(CalendarViewControl parentView)
		{
			ParentView = parentView;
			SelectedDays = new List<CalendarDay>();
		}

		public CalendarViewControl ParentView { get; private set; }
		public List<CalendarDay> SelectedDays { get; private set; }

		public event EventHandler<EventArgs> SelectionStateResponse;

		public void ClearSelection()
		{
			foreach (var day in SelectedDays)
				ParentView.SelectDay(day, false);
			SelectedDays.Clear();
		}

		public void ProcessSelectionStateRequest()
		{
			if (SelectionStateResponse != null)
				SelectionStateResponse(this, new EventArgs());
		}

		public void SelectDay(CalendarDay day, Keys modifierKeys)
		{
			var ctrlSelect = (modifierKeys & Keys.Control) == Keys.Control;
			var shiftSelect = (modifierKeys & Keys.Shift) == Keys.Shift;
			if (!(ctrlSelect | shiftSelect))
				ClearSelection();
			if (shiftSelect)
			{
				var prevSelectedDay = SelectedDays.LastOrDefault();
				if (prevSelectedDay != null)
				{
					var minDate = prevSelectedDay.Date > day.Date ? day.Date : prevSelectedDay.Date;
					var maxDate = prevSelectedDay.Date < day.Date ? day.Date : prevSelectedDay.Date;
					foreach (var dayToSelect in ParentView.Calendar.Days.Where(d => (d.Date >= minDate && d.Date < maxDate) && !SelectedDays.Contains(d)))
					{
						ParentView.SelectDay(dayToSelect, true);
						SelectedDays.Add(dayToSelect);
					}
				}
			}
			if (SelectedDays.Contains(day)) return;
			ParentView.SelectDay(day, true);
			SelectedDays.Add(day);
		}
	}
}
