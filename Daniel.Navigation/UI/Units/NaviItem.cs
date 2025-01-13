using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Daniel.Navigation.UI.Units;
public class NaviItem : TreeViewItem
{
	static NaviItem()
	{
		DefaultStyleKeyProperty.OverrideMetadata(typeof(NaviItem),
				  new FrameworkPropertyMetadata(typeof(NaviItem)));
	}
	 
}
