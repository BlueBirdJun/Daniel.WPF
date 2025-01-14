using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Daniel.WPF.Task1.UI.Units;
public class NightDayButton : JamesToggleSwitch
{
	static NightDayButton()
	{
		DefaultStyleKeyProperty.OverrideMetadata(typeof(NightDayButton), new FrameworkPropertyMetadata(typeof(NightDayButton)));
	}
}
