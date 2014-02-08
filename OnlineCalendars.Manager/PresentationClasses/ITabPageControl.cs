using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineCalendars.Manager.PresentationClasses
{
	interface ITabPageControl
	{
		void SaveData(string fileName = "");
	}
}
