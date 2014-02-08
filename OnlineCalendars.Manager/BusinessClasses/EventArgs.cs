using System;
using System.Collections.Generic;

namespace OnlineCalendars.Manager.BusinessClasses
{
	public class ConfigurationEventArgs : EventArgs
	{
		public string ConfigurationFilePath { get; set; }
	}

	public class ConfigurationSaveEventArgs : EventArgs
	{
		public ConfigurationSaveEventArgs(bool quickSave)
		{
			QuickSave = quickSave;
		}

		public bool QuickSave { get; set; }
	}

	public class ConfigurationChangeEventArgs : EventArgs
	{
		public List<Guid> ChangedCalendarIds { get; private set; }

		public ConfigurationChangeEventArgs()
		{
			ChangedCalendarIds = new List<Guid>();
		}
	}

	public class CalendarEventArgs : EventArgs
	{
		public Guid CalendarId { get; set; }
	}
}
