using System.Windows.Forms;
using OnlineCalendars.Manager.BusinessClasses;

namespace OnlineCalendars.Manager.ToolForms
{
	public partial class FormStart : Form
	{
		public FormStart()
		{
			InitializeComponent();
			Text = SettingsManager.ApplicationName;
		}
	}
}