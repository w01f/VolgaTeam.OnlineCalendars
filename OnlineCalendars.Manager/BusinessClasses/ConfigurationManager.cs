using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using OnlineCalendars.Manager.Common;

namespace OnlineCalendars.Manager.BusinessClasses
{
	public class ConfigurationManager
	{
		private Configuration _currentConfiguration;

		public bool ConfigurationLoaded { get; set; }
		public event EventHandler<ConfigurationSaveEventArgs> SettingsSaved;

		public void OpenConfiguration(string configurationName, bool create)
		{
			var configurationFilePath = GetConfigurationFileName(configurationName);
			if (!File.Exists(configurationFilePath) && !create) return;
			if (create)
				if (Utilities.Instance.ShowWarningQuestion("An older configuration is already saved with this same file name.\nDo you want to replace this file with a newer configuration?") == DialogResult.Yes)
					File.Delete(configurationFilePath);
			OpenConfiguration(configurationFilePath);
		}

		private void OpenConfiguration(string configurationFilePath)
		{
			_currentConfiguration = new Configuration(configurationFilePath);
			SettingsManager.Instance.LastOpenConfiguration = _currentConfiguration.Name;
			SettingsManager.Instance.SaveSettings();
			ConfigurationLoaded = true;
		}

		public void CreateConfiguration(string configurationName)
		{
			OpenConfiguration(configurationName, true);
		}

		public string GetConfigurationFileName(string scheduleName)
		{
			return Path.Combine(SettingsManager.Instance.SaveFolder, scheduleName + ".xml");
		}

		public Configuration GetLocalConfiguration()
		{
			return new Configuration(_currentConfiguration.ConfigurationFile.FullName);
		}

		public ShortConfiguration GetShortConfiguration()
		{
			return new ShortConfiguration(_currentConfiguration.ConfigurationFile);
		}

		public void SaveConfiguration(Configuration localConfiguration, bool quickSave, Control sender)
		{
			localConfiguration.Save();
			_currentConfiguration = localConfiguration;
			if (SettingsSaved != null)
				SettingsSaved(sender, new ConfigurationSaveEventArgs(quickSave));
		}

		public static ShortConfiguration[] GetShortConfigurationList(DirectoryInfo rootFolder)
		{
			return rootFolder.GetFiles("*.xml").Select(file => new ShortConfiguration(file)).ToArray();
		}

		public static ShortConfiguration[] GetShortConfigurationList()
		{
			var saveFolder = new DirectoryInfo(SettingsManager.Instance.SaveFolder);
			return saveFolder.Exists ? GetShortConfigurationList(saveFolder) : null;
		}

		public void RemoveInstance()
		{
			SettingsSaved = null;
		}
	}

	public class ShortConfiguration
	{
		private readonly FileInfo _configurationFile;

		public string ShortFileName
		{
			get { return _configurationFile.Name.Replace(_configurationFile.Extension, ""); }
		}

		public string FullFileName
		{
			get { return _configurationFile.FullName; }
		}

		public DateTime LastModifiedDate
		{
			get { return _configurationFile.LastWriteTime; }
		}

		public ShortConfiguration(FileInfo file)
		{
			_configurationFile = file;
		}
	}

	public class Configuration
	{
		private FileInfo _configurationFile { get; set; }

		public string Site { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public List<Calendar> Calendars { get; private set; }

		public string Name
		{
			get { return _configurationFile.Name.Replace(_configurationFile.Extension, ""); }
			set { _configurationFile = new FileInfo(Path.Combine(_configurationFile.Directory.FullName, value + ".xml")); }
		}

		public FileInfo ConfigurationFile
		{
			get { return _configurationFile; }
		}

		public bool IsConfigured
		{
			get { return !String.IsNullOrEmpty(Site) && !String.IsNullOrEmpty(Login) && !String.IsNullOrEmpty(Password); }
		}

		public Configuration(string fileName)
		{
			Calendars = new List<Calendar>();

			if (!File.Exists(fileName))
			{
				var xml = new StringBuilder();
				xml.AppendLine(@"<Configuration>");
				xml.AppendLine(@"</Configuration>");
				using (var sw = new StreamWriter(fileName, false))
				{
					sw.Write(xml);
					sw.Flush();
				}
			}
			_configurationFile = new FileInfo(fileName);
			Load();
		}

		private void Load()
		{
			if (!_configurationFile.Exists) return;
			var document = new XmlDocument();
			document.Load(_configurationFile.FullName);

			var node = document.SelectSingleNode(@"/Configuration/Site");
			if (node != null)
				Site = node.InnerXml;
			node = document.SelectSingleNode(@"/Configuration/Login");
			if (node != null)
				Login = node.InnerXml;
			node = document.SelectSingleNode(@"/Configuration/Password");
			if (node != null)
				Password = node.InnerXml;

			foreach (var calendarNode in document.SelectNodes("//Configuration/Calendar").OfType<XmlNode>())
			{
				var calendar = new Calendar();
				calendar.Deserialize(calendarNode);
				Calendars.Add(calendar);
			}
		}

		public void Save()
		{
			var xml = new StringBuilder();

			xml.AppendLine(@"<Configuration>");

			if (!String.IsNullOrEmpty(Site))
				xml.AppendLine(String.Format("<Site>{0}</Site>", Site.Replace(@"&", "&#38;").Replace("\"", "&quot;")));
			if (!String.IsNullOrEmpty(Login))
				xml.AppendLine(String.Format("<Login>{0}</Login>", Login.Replace(@"&", "&#38;").Replace("\"", "&quot;")));
			if (!String.IsNullOrEmpty(Password))
				xml.AppendLine(String.Format("<Password>{0}</Password>", Password.Replace(@"&", "&#38;").Replace("\"", "&quot;")));

			foreach (var calendar in Calendars)
				xml.AppendLine(calendar.Serialize());

			xml.AppendLine(@"</Configuration>");

			using (var sw = new StreamWriter(_configurationFile.FullName, false))
			{
				sw.Write(xml);
				sw.Flush();
			}
		}
	}

	public class Calendar
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime? DateStart { get; set; }
		public DateTime? DateEnd { get; set; }
		public DateTime LastModified { get; set; }

		public Configuration Configuration { get; private set; }

		public List<CalendarMonth> Months { get; private set; }
		public List<CalendarDay> Days { get; private set; }

		public string SlideColor { get; set; }

		public string Range
		{
			get { return DateStart.HasValue && DateEnd.HasValue ? String.Format("{0} - {1}", DateStart.Value.ToString("MM/dd/yy"), DateEnd.Value.ToString("MM/dd/yy")) : String.Empty; }
		}

		public Color SlideColorLight
		{
			get
			{
				switch (SlideColor)
				{
					case "black":
						return Color.White;
					case "blue":
						return Color.LightBlue;
					case "gray":
						return Color.LightGray;
					case "green":
						return Color.LightGreen;
					case "orange":
						return Color.FromArgb(255, 224, 192);
					case "teal":
						return Color.Cyan;
					default:
						return Color.White;
				}
			}
		}

		public Color SlideColorDark
		{
			get
			{
				switch (SlideColor)
				{
					case "black":
						return Color.Black;
					case "blue":
						return Color.Blue;
					case "gray":
						return Color.Gray;
					case "green":
						return Color.Green;
					case "orange":
						return Color.Orange;
					case "teal":
						return Color.Teal;
					default:
						return Color.Black;
				}
			}
		}

		public Calendar()
		{
			Id = Guid.NewGuid();
			LastModified = DateTime.Now;
			Days = new List<CalendarDay>();
			Months = new List<CalendarMonth>();

			SlideColor = "gray";
		}

		public string Serialize()
		{
			var result = new StringBuilder();
			result.AppendLine("<Calendar>");
			result.AppendLine(String.Format("<Id>{0}</Id>", Id));
			result.AppendLine(String.Format("<Name>{0}</Name>", Name.Replace(@"&", "&#38;").Replace("\"", "&quot;")));
			if (DateStart.HasValue)
				result.AppendLine(String.Format("<DateStart>{0}</DateStart>", DateStart.Value));
			if (DateEnd.HasValue)
				result.AppendLine(String.Format("<DateEnd>{0}</DateEnd>", DateEnd.Value));
			foreach (var month in Months)
				result.AppendLine(@"<Month>" + month.Serialize() + @"</Month>");
			foreach (var day in Days)
				result.AppendLine(@"<Day>" + day.Serialize() + @"</Day>");
			result.AppendLine(String.Format("<LastModified>{0}</LastModified>", LastModified));
			result.AppendLine("</Calendar>");
			return result.ToString();
		}

		public void Deserialize(XmlNode node)
		{
			Days.Clear();
			Months.Clear();
			foreach (var childNode in node.ChildNodes.OfType<XmlNode>())
			{
				switch (childNode.Name)
				{
					case "Id":
						{
							Guid temp;
							if (Guid.TryParse(childNode.InnerText, out temp))
								Id = temp;
						}
						break;
					case "Name":
						Name = childNode.InnerText;
						break;
					case "DateStart":
						{
							DateTime temp;
							if (DateTime.TryParse(childNode.InnerText, out temp))
								DateStart = temp;
						}
						break;
					case "DateEnd":
						{
							DateTime temp;
							if (DateTime.TryParse(childNode.InnerText, out temp))
								DateEnd = temp;
						}
						break;
					case "Day":
						var day = new CalendarDay(this);
						day.Deserialize(childNode);
						Days.Add(day);
						break;
					case "Month":
						var month = new CalendarMonth(this);
						month.Deserialize(childNode);
						Months.Add(month);
						break;
				}
			}
			UpdateDaysCollection();
			UpdateMonthCollection();
		}

		public Calendar Clone()
		{
			var newCalendar = new Calendar
			{
				Name = Name,
				DateStart = DateStart,
				DateEnd = DateEnd
			};
			newCalendar.Days.AddRange(Days.Select(d => d.Clone()));
			return newCalendar;
		}

		public void UpdateDaysCollection()
		{
			if (DateStart.HasValue && DateEnd.HasValue)
			{
				var days = new List<CalendarDay>();

				var startDate = new DateTime(DateStart.Value.Year, DateStart.Value.Month, 1);
				while (startDate.DayOfWeek != DayOfWeek.Sunday)
					startDate = startDate.AddDays(-1);

				var endDate = new DateTime(DateEnd.Value.Month < 12 ? DateEnd.Value.Year : (DateEnd.Value.Year + 1), (DateEnd.Value.Month < 12 ? DateEnd.Value.Month + 1 : 1), 1).AddDays(-1);
				while (endDate.DayOfWeek != DayOfWeek.Saturday)
					endDate = endDate.AddDays(1);

				while (startDate <= endDate)
				{
					var day = Days.FirstOrDefault(x => x.Date.Equals(startDate));
					if (day == null)
					{
						day = new CalendarDay(this);
						day.Date = startDate;
					}
					day.BelongsToSchedules = day.Date >= DateStart & day.Date <= DateEnd;
					days.Add(day);
					startDate = startDate.AddDays(1);
				}
				Days.Clear();
				Days.AddRange(days);
			}
			else
				Days.Clear();

		}

		public void UpdateMonthCollection()
		{
			if (DateStart.HasValue && DateEnd.HasValue)
			{
				var months = new List<CalendarMonth>();
				var startDate = new DateTime(DateStart.Value.Year, DateStart.Value.Month, 1);
				while (startDate <= DateEnd.Value)
				{
					var month = Months.FirstOrDefault(x => x.Date.Equals(startDate));
					if (month == null)
					{
						month = new CalendarMonth(this);
						month.Date = startDate;
					}
					month.Days.Clear();
					month.Days.AddRange(Days.Where(x => x.Date >= month.DaysRangeBegin && x.Date <= month.DaysRangeEnd));
					months.Add(month);
					startDate = startDate.AddMonths(1);
				}
				Months.Clear();
				Months.AddRange(months);
			}
			else
				Months.Clear();
		}

		public IEnumerable<DateRange> CalculateDateRange(IEnumerable<DateTime> dates)
		{
			var result = new List<DateRange>();
			var selectedDates = new List<DateTime>();
			selectedDates.AddRange(dates);
			selectedDates.Sort();

			var firstSelectedDate = selectedDates.FirstOrDefault();
			var lastSelectedDate = selectedDates.LastOrDefault();
			var firstWeekday = firstSelectedDate;
			while (firstWeekday.DayOfWeek != DayOfWeek.Sunday)
				firstWeekday = firstWeekday.AddDays(-1);
			var lastWeekday = firstSelectedDate;
			while (lastWeekday.DayOfWeek != DayOfWeek.Saturday)
				lastWeekday = lastWeekday.AddDays(1);

			while (firstWeekday < lastSelectedDate)
			{
				var range = new DateRange();
				if (firstWeekday >= firstSelectedDate && lastWeekday <= lastSelectedDate)
				{
					range.StartDate = firstWeekday;
					range.FinishDate = lastWeekday;
				}
				else if (firstWeekday <= firstSelectedDate && lastWeekday >= lastSelectedDate)
				{
					range.StartDate = firstSelectedDate;
					range.FinishDate = lastSelectedDate;
				}
				else if (firstWeekday <= firstSelectedDate && lastWeekday >= firstSelectedDate)
				{
					range.StartDate = firstSelectedDate;
					range.FinishDate = lastWeekday;
				}
				else if (firstWeekday <= lastSelectedDate && lastWeekday >= lastSelectedDate)
				{
					range.StartDate = firstWeekday;
					range.FinishDate = lastSelectedDate;
				}
				result.Add(range);
				firstWeekday = firstWeekday.AddDays(7);
				lastWeekday = lastWeekday.AddDays(7);
			}
			return result;
		}

		public DateTime[][] GetDaysByWeek(DateTime start, DateTime end)
		{
			var weeks = new List<DateTime[]>();
			var week = new List<DateTime>();
			while (!(start > end))
			{
				week.Add(start);
				if (start.DayOfWeek == DayOfWeek.Saturday)
				{
					weeks.Add(week.ToArray());
					week.Clear();
				}
				start = start.AddDays(1);
			}
			if (week.Count > 0)
				weeks.Add(week.ToArray());
			return weeks.ToArray();
		}
	}

	public class CalendarMonth
	{
		protected DateTime _date;

		public CalendarMonth(Calendar parent)
		{
			Parent = parent;
			Days = new List<CalendarDay>();
		}

		public Calendar Parent { get; private set; }
		public DateTime DaysRangeBegin { get; set; }
		public DateTime DaysRangeEnd { get; set; }
		public List<CalendarDay> Days { get; private set; }

		public DateTime Date
		{
			get { return _date; }
			set
			{
				_date = value;
				DaysRangeBegin = _date;
				DaysRangeEnd = _date.AddMonths(1).AddDays(-1);
			}
		}

		public string Serialize()
		{
			var result = new StringBuilder();
			result.AppendLine(@"<Date>" + _date + @"</Date>");
			return result.ToString();
		}

		public void Deserialize(XmlNode node)
		{
			foreach (XmlNode childNode in node.ChildNodes)
			{
				switch (childNode.Name)
				{
					case "Date":
						DateTime tempDate;
						if (DateTime.TryParse(childNode.InnerText, out tempDate))
							Date = tempDate;
						break;
				}
			}
		}
	}

	public class CalendarDay
	{
		public CalendarDay(Calendar parent)
		{
			Parent = parent;
			Id = Guid.NewGuid();
		}

		public Guid Id { get; set; }
		public Calendar Parent { get; private set; }
		public DateTime Date { get; set; }
		public bool BelongsToSchedules { get; set; }
		public string Comment { get; set; }

		public string Summary
		{
			get
			{
				var result = new StringBuilder();
				if (!String.IsNullOrEmpty(Comment))
					result.AppendLine(Comment);
				return result.ToString();
			}
		}

		public bool ContainsData
		{
			get { return !String.IsNullOrEmpty(Summary); }
		}

		public int WeekDayIndex
		{
			get
			{
				switch (Date.DayOfWeek)
				{
					case DayOfWeek.Sunday:
						return 1;
					case DayOfWeek.Monday:
						return 2;
					case DayOfWeek.Tuesday:
						return 3;
					case DayOfWeek.Wednesday:
						return 4;
					case DayOfWeek.Thursday:
						return 5;
					case DayOfWeek.Friday:
						return 6;
					case DayOfWeek.Saturday:
						return 7;
					default:
						return 0;
				}
			}
		}

		public string Serialize()
		{
			var result = new StringBuilder();
			result.AppendLine(String.Format("<Id>{0}</Id>", Id));
			result.AppendLine(String.Format(@"<Date>{0}</Date>", Date));
			if (!string.IsNullOrEmpty(Comment))
				result.AppendLine(String.Format(@"<Comment>{0}</Comment>", Comment.Replace(@"&", "&#38;").Replace("\"", "&quot;")));

			return result.ToString();
		}

		public void Deserialize(XmlNode node)
		{
			foreach (XmlNode childNode in node.ChildNodes)
			{
				switch (childNode.Name)
				{
					case "Id":
						{
							Guid temp;
							if (Guid.TryParse(childNode.InnerText, out temp))
								Id = temp;
						}
						break;
					case "Date":
						{
							DateTime temp;
							if (DateTime.TryParse(childNode.InnerText, out temp))
								Date = temp;
						}
						break;
					case "Comment":
						Comment = childNode.InnerText;
						break;
				}
			}
		}

		public void ClearData()
		{
			Comment = null;
		}

		public CalendarDay Clone()
		{
			var newDay = new CalendarDay(Parent)
			{
				Date = Date,
				Comment = Comment
			};
			return newDay;
		}
	}

	public class DateRange
	{
		public DateTime StartDate { get; set; }
		public DateTime FinishDate { get; set; }

		public string Range
		{
			get { return StartDate.ToString("MM/dd/yy") + "-" + FinishDate.ToString("MM/dd/yy"); }
		}
	}
}
