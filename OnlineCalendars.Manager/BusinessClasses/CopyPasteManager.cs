using System;

namespace OnlineCalendars.Manager.BusinessClasses
{
	public class CopyPasteManager
	{
		public CalendarDay SourceDay { get; private set; }

		public event EventHandler<EventArgs> DayCopied;
		public event EventHandler<EventArgs> DayPasted;

		public event EventHandler<EventArgs> OnSetCopyDay;
		public event EventHandler<EventArgs> OnResetCopy;
		public event EventHandler<EventArgs> OnResetPaste;

		public void SetCopyDay()
		{
			if (OnSetCopyDay != null)
				OnSetCopyDay(null, null);
		}

		public void ResetCopy()
		{
			if (OnResetCopy != null)
				OnResetCopy(null, null);
		}

		public void ResetPaste()
		{
			SourceDay = null;
			if (OnResetPaste != null)
				OnResetPaste(null, null);
		}

		public void CopyDay(CalendarDay source)
		{
			SourceDay = source;
			if (SourceDay == null) return;
			if (DayCopied != null)
				DayCopied(null, null);
		}

		public void CloneDay(CalendarDay source, CalendarDay[] destination)
		{
			if (source == null || destination == null) return;
			foreach (var day in destination)
				day.Comment = source.Comment;
			if (DayPasted != null)
				DayPasted(null, null);
		}

		public void PasteDay(CalendarDay[] destination)
		{
			if (SourceDay == null || destination == null) return;
			foreach (var day in destination)
				day.Comment = SourceDay.Comment;
			if (DayPasted != null)
				DayPasted(null, null);
		}
	}
}
