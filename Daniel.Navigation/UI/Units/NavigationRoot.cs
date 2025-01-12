using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Daniel.Navigation.UI.Units;
public class NavigationRoot : TreeView
{
	static NavigationRoot() {
		DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationRoot),
				  new FrameworkPropertyMetadata(typeof(NavigationRoot)));
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new NaviItem();
	}
}
