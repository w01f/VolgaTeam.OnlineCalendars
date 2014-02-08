using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineCalendars.Manager.PresentationClasses
{
	[ToolboxItem(false)]
	public sealed partial class SiteUsersControl : UserControl,ITabPageControl
	{
		public SiteUsersControl()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
		}

		public void LoadData(bool quickLoad)
		{
		}

		public void SaveData(string fileName = "")
		{
		}
	}
}
