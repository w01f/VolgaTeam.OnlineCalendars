using System;
using System.Linq;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.SyncService;

namespace OnlineCalendars.Manager.Services
{
	public class SyncHelper
	{
		private readonly Configuration _configuration;

		public SyncHelper(Configuration configuration)
		{
			_configuration = configuration;
		}

		public void Sync(out string message)
		{
			var client = new SiteClient(_configuration.Site, _configuration.Login, _configuration.Password);
			message = String.Empty;
			client.UpdateCalendars(_configuration.Calendars.Select(CalendarModel.MapFromCalendar).ToArray(), out message);
		}
	}
}
