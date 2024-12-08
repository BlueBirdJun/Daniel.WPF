
using Daniel.WPF.Support.UI.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Daniel.App.UI.Views;
public class MainWindow : DarkWindow
{
	static MainWindow()
	{
		DefaultStyleKeyProperty.OverrideMetadata(
			  typeof(MainWindow),
			  new FrameworkPropertyMetadata(typeof(MainWindow)));
	}
	 

}
