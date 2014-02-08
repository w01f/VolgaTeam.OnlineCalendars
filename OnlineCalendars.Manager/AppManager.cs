using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using OnlineCalendars.Manager.Common;

namespace OnlineCalendars.Manager
{
	public class AppManager
	{
		private static readonly AppManager _instance = new AppManager();

		private AppManager() { }

		public static AppManager Instance
		{
			get { return _instance; }
		}

		public void RunForm()
		{
			Application.Run(FormMain.Instance);
		}


		public void ActivateMainForm()
		{
			var processList = Process.GetProcesses();
			foreach (Process process in processList.Where(x => x.ProcessName.ToLower().Contains("calbookit")))
			{
				if (process.MainWindowHandle.ToInt32() != 0)
				{
					Utilities.Instance.ActivateForm(process.MainWindowHandle, true, false);
					break;
				}
			}
		}
	}
}
