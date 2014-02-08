using System.Windows.Forms;

namespace OnlineCalendars.Manager.ToolForms
{
	public partial class FormNewSchedule : Form
	{
		public FormNewSchedule()
		{
			InitializeComponent();
		}

		public string ScheduleName
		{
			get
			{
				if (textEditName.EditValue != null)
					return textEditName.EditValue.ToString();
				return null;
			}
		}

		private void textEditScheduleName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}