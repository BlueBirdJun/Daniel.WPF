using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Jamesnet.Windows;

namespace Daniel.WPF.Task1.UI.Units;
public class CustomCalendar :WPFView
{
	static CustomCalendar()
	{
		DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomCalendar),
				  new FrameworkPropertyMetadata(typeof(CustomCalendar)));
	}
}
