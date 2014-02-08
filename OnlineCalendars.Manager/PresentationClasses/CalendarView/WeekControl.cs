using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OnlineCalendars.Manager.PresentationClasses.CalendarView
{
	[ToolboxItem(false)]
	public partial class WeekControl : UserControl
	{
		private readonly List<DayControl> _dayControls = new List<DayControl>();
		private readonly WeekEmptySpaceControl _footer;
		private readonly WeekEmptySpaceControl _header;

		private readonly int _maxWeekDayIndex;
		private readonly int _minWeekDayIndex;

		public WeekControl(DayControl[] days)
		{
			InitializeComponent();
			Dock = DockStyle.Top;
			Resize += WeekControl_Resize;

			if (days.Length > 0)
			{
				_dayControls.AddRange(days);
				Controls.AddRange(days);
				_maxWeekDayIndex = _dayControls.Max(x => x.Day.WeekDayIndex);
				if (_maxWeekDayIndex < 7)
				{
					_footer = new WeekEmptySpaceControl();
					Controls.Add(_footer);
				}

				_minWeekDayIndex = _dayControls.Min(x => x.Day.WeekDayIndex);
				if (_maxWeekDayIndex > 1)
				{
					_header = new WeekEmptySpaceControl();
					Controls.Add(_header);
				}
				FitControls();
			}
		}

		public void RefreshData(Color colorLight, Color colorDark)
		{
			foreach (var day in _dayControls)
				day.RefreshData(colorLight, colorDark);
		}

		public void RaiseEvents(bool enable)
		{
			foreach (var day in _dayControls)
				day.RaiseEvents = enable;
		}

		private void FitControls()
		{
			FitDays();
		}

		private void FitDays()
		{
			double height = Height;
			double width = Width / 7;

			if (_header != null)
			{
				_header.Top = 0;
				_header.Left = 0;
				_header.Height = (int)height;
				_header.Width = ((int)width * (_minWeekDayIndex - 1));
			}

			if (_footer != null)
			{
				_footer.Top = 0;
				_footer.Left = (int)width * _maxWeekDayIndex;
				_footer.Height = (int)height;
				_footer.Width = Width - ((int)width * _maxWeekDayIndex);
			}

			foreach (var dayControl in _dayControls)
			{
				dayControl.Top = 0;
				dayControl.Height = (int)height;
				dayControl.Left = (dayControl.Day.WeekDayIndex - 1) * (int)width;
				dayControl.Width = dayControl.Day.WeekDayIndex == 7 ? Width - ((int)width * 6) : (int)width;
			}
		}

		private void WeekControl_Resize(object sender, EventArgs e)
		{
			FitControls();
		}
	}
}