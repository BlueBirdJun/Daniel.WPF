using Jamesnet.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Daniel.Navigation.UI.Views;
public class NavigationView:WPFView
{
	static NavigationView()
	{  
	   
		DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationView),
				  new FrameworkPropertyMetadata(typeof(NavigationView)));
	}	
}
