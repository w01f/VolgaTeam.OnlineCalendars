using System.Linq;
using OnlineCalendars.Manager.BusinessClasses;

namespace OnlineCalendars.Manager.SyncService
{
	public partial class CalendarModel
	{
		public static CalendarModel MapFromCalendar(Calendar calendar)
		{
			var model = new CalendarModel
			{
				id = calendar.Id.ToString(),
				name = calendar.Name,
				dateStart = calendar.DateStart.Value.ToString("MM/dd/yyyy hh:mm:ss tt"),
				dateEnd = calendar.DateEnd.Value.ToString("MM/dd/yyyy hh:mm:ss tt"),
				lastModified = calendar.LastModified.ToString("MM/dd/yyyy hh:mm:ss tt")
			};
			model.days = calendar.Days.Where(d => d.ContainsData).Select(DayModel.MapFromCalendarDay).ToArray();
			return model;
		}
	}
}
