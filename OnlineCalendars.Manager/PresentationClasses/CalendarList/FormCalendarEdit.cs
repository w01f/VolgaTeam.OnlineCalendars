using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using OnlineCalendars.Manager.Common;

namespace OnlineCalendars.Manager.PresentationClasses.CalendarList
{
	public partial class FormCalendarEdit : Form
	{
		public string CalendarName
		{
			get { return textEditName.EditValue as String; }
			set { textEditName.EditValue = value; }
		}

		public DateTime? CalendarStart
		{
			get { return dateEditStart.EditValue != null ? dateEditStart.DateTime : (DateTime?)null; }
			set { dateEditStart.EditValue = value; }
		}

		public DateTime? CalendarEnd
		{
			get { return dateEditEnd.EditValue != null ? dateEditEnd.DateTime : (DateTime?)null; }
			set { dateEditEnd.EditValue = value; }
		}

		public FormCalendarEdit()
		{
			InitializeComponent();
			Text = @"Edit Calendar";

			textEditName.Enter += Utilities.Instance.Editor_Enter;
			textEditName.MouseUp += Utilities.Instance.Editor_MouseUp;
			textEditName.MouseDown += Utilities.Instance.Editor_MouseDown;
		}

		private void FormCalendarEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK) return;

			var cancel = false;
			var errors = new StringBuilder();

			if (String.IsNullOrEmpty(CalendarName))
			{
				cancel = true;
				errors.AppendLine("You need to set Calendar Name");
			}
			if (!CalendarStart.HasValue)
			{
				cancel = true;
				errors.AppendLine("You need to set Calendar Start date");
			}
			if (!CalendarEnd.HasValue)
			{
				cancel = true;
				errors.AppendLine("You need to set Calendar End date");
			}
			if (CalendarStart.HasValue && CalendarEnd.HasValue && CalendarStart.Value > CalendarEnd.Value)
			{
				cancel = true;
				errors.AppendLine("Calendar Start date should be less then Calendar End date");
			}

			if (!cancel) return;

			e.Cancel = true;
			toolTipController.HideHint();
			toolTipController.ShowHint(errors.ToString(), simpleButtonSave, ToolTipLocation.TopCenter);
		}
	}

	public class FormCalendarNew : FormCalendarEdit
	{
		public FormCalendarNew()
		{
			Text = @"Create New Calendar";
		}
	}

	public class FormCalendarClone : FormCalendarEdit
	{
		public FormCalendarClone()
		{
			Text = @"Clone Calendar";
		}
	}
}
