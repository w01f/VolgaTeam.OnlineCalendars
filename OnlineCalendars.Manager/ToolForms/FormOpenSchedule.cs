using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using OnlineCalendars.Manager.BusinessClasses;
using OnlineCalendars.Manager.Common;

namespace OnlineCalendars.Manager.ToolForms
{
	public partial class FormOpenSchedule : Form
	{
		private ShortConfiguration[] _scheduleList;

		public FormOpenSchedule()
		{
			InitializeComponent();
		}

		public string ScheduleName { get; set; }

		public void LoadConfiguration()
		{
			_scheduleList = ConfigurationManager.GetShortConfigurationList();
			gridControlFiles.Visible = true;
			gridControlFiles.DataSource = new BindingList<ShortConfiguration>(_scheduleList);
			if (gridViewFiles.RowCount > 0)
				gridViewFiles.FocusedRowHandle = 0;
		}

		private void FormOpenSchedule_Load(object sender, EventArgs e)
		{
			LoadConfiguration();
		}

		private void barLargeButtonItemOpen_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (gridViewFiles.FocusedRowHandle >= 0)
			{
				ScheduleName = _scheduleList[gridViewFiles.GetFocusedDataSourceRowIndex()].ShortFileName;
				DialogResult = DialogResult.OK;
				Close();
			}
			else
				Utilities.Instance.ShowWarning("Please select configuration in list");
		}

		private void barLargeButtonItemDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (Utilities.Instance.ShowWarningQuestion("Delete this Configuration?") != DialogResult.Yes) return;
			var fileName = _scheduleList[gridViewFiles.GetFocusedDataSourceRowIndex()].FullFileName;
			try
			{
				if (File.Exists(fileName))
					File.Delete(fileName);
			}
			catch
			{
				Utilities.Instance.ShowWarning("Couldn't delete selected schedule.");
			}
			LoadConfiguration();
		}

		private void barLargeButtonItemExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			DialogResult = DialogResult.None;
			Close();
		}

		private void gridViewSchedules_RowClick(object sender, RowClickEventArgs e)
		{
			if (e.Clicks == 2)
				barLargeButtonItemOpen_ItemClick(null, null);
		}
	}
}