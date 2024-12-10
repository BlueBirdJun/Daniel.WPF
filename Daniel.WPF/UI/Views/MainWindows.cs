using Daniel.WPF.Support.UI.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Daniel.WPF.UI.Views;

public class MainWindows : DarkWindow
{
	static MainWindows()
	{
		DefaultStyleKeyProperty.OverrideMetadata(
			  typeof(MainWindows),
			  new FrameworkPropertyMetadata(typeof(MainWindows)));
	}


}