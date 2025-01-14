using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Jamesnet.Windows;

namespace Daniel.WPF.Task1.UI.Units;
public class NavigationBar:WPFView
{
	static NavigationBar()
	{
		DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationBar),
			  new FrameworkPropertyMetadata(typeof(NavigationBar)));
	}
}
