using System;
using OnlineCalendars.Manager.SyncService;

namespace OnlineCalendars.Manager.Services
{
	class SiteClient
	{
		protected string _login;
		protected string _password;

		public string _website;

		public SiteClient(string website, string login, string password)
		{
			_website = website;
			_login = login;
			_password = password;
		}

		#region Sync Service
		private SyncControllerService GetSyncClient()
		{
			try
			{
				var client = new SyncControllerService();
				client.Url = string.Format("{0}/sync/quote?ws=1", _website);
				return client;
			}
			catch
			{
				return null;
			}
		}

		public void UpdateCalendars(CalendarModel[] calendars, out string message)
		{
			message = string.Empty;
			var client = GetSyncClient();
			if (client != null)
			{
				try
				{
					string sessionKey = client.getSessionKey(_login, _password);
					if (!string.IsNullOrEmpty(sessionKey))
						client.updateCalendars(sessionKey, calendars);
					else
						message = "Couldn't complete operation.\nLogin or password are not correct.";
				}
				catch (Exception ex)
				{
					message = string.Format("Couldn't complete operation.\n{0}.", ex.Message);
				}
			}
			else
				message = "Couldn't complete operation.\nServer is unavailable.";
		}
		#endregion

	}
}
