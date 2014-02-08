using System;
using System.IO;
using System.Text;
using System.Xml;

namespace OnlineCalendars.Manager.BusinessClasses
{
	public class SettingsManager
	{
		private static readonly SettingsManager _instance = new SettingsManager();
		private readonly string _settingsFileName = String.Format(@"{0}\newlocaldirect.com\xml\app_online_calendar\Settings.xml", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
		public const string ApplicationName = "Calbookit";

		private SettingsManager()
		{
			ApplicationRootsPath = Path.GetDirectoryName(typeof(SettingsManager).Assembly.Location);
			HelpLinksPath = string.Format(@"{0}\newlocaldirect.com\app\HelpUrls\calbookit.xml", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			IconPath = Path.Combine(ApplicationRootsPath, "icon.ico");
			SaveFolder = String.Format(@"{0}\newlocaldirect.com\xml\app_online_calendar\Saved Configurations", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			if (!Directory.Exists(SaveFolder))
				Directory.CreateDirectory(SaveFolder);
			LoadSettings();
		}

		public string ApplicationRootsPath { get; private set; }
		public string SaveFolder { get; set; }
		public string HelpLinksPath { get; set; }
		public string IconPath { get; set; }

		#region Local Settings
		public string LastOpenConfiguration { get; set; }
		public string LastSelectedCalendarId { get; set; }
		#endregion

		public static SettingsManager Instance
		{
			get { return _instance; }
		}

		private void LoadSettings()
		{
			if (!File.Exists(_settingsFileName)) return;
			var document = new XmlDocument();
			document.Load(_settingsFileName);
			var node = document.SelectSingleNode(@"/Settings/LastOpenConfiguration");
			if (node != null)
				LastOpenConfiguration = node.InnerText;
			node = document.SelectSingleNode(@"/Settings/LastSelectedCalendarId");
			if (node != null)
				LastSelectedCalendarId = node.InnerText;
		}

		public void SaveSettings()
		{
			var xml = new StringBuilder();

			xml.AppendLine(@"<Settings>");
			if (!String.IsNullOrEmpty(LastOpenConfiguration))
				xml.AppendLine(@"<LastOpenConfiguration>" + LastOpenConfiguration.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</LastOpenConfiguration>");
			if (!String.IsNullOrEmpty(LastSelectedCalendarId))
				xml.AppendLine(@"<LastSelectedCalendarId>" + LastSelectedCalendarId.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</LastSelectedCalendarId>");
			xml.AppendLine(@"</Settings>");

			var settingsFolder = Path.GetDirectoryName(_settingsFileName);
			if (!Directory.Exists(settingsFolder))
				Directory.CreateDirectory(settingsFolder);
			using (var sw = new StreamWriter(_settingsFileName, false))
			{
				sw.Write(xml);
				sw.Flush();
			}
		}
	}
}
