using OnlineCalendars.Manager.BusinessClasses;

namespace OnlineCalendars.Manager.SyncService
{
	public partial class DayModel
	{
		public static DayModel MapFromCalendarDay(CalendarDay day)
		{
			return new DayModel
			{
				id = day.Id.ToString(),
				comment = day.Comment,
				date = day.Date.ToString("MM/dd/yyyy hh:mm:ss tt"),
			};
		}
	}
}
