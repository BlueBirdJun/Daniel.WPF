using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Daniel.Navigation.Local.Models;

namespace Daniel.Navigation.UI.Units;
public class NavigationRoot : TreeView
{
	public static readonly DependencyProperty SelectionCommandProperty =
			 DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(NavigationRoot));

	static NavigationRoot() {
		DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationRoot),
				  new FrameworkPropertyMetadata(typeof(NavigationRoot)));
	}
	public ICommand SelectionCommand
	{
		get => (ICommand)GetValue(SelectionCommandProperty);
		set => SetValue(SelectionCommandProperty, value);
	}
	public NavigationRoot()
	{
		SelectedItemChanged += TreeView_SelectedItemChanged;
	}
	private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
	{
		if (SelectedItem is NaviItemModel item)
		{
			SelectionCommand?.Execute(item);
		}
	}
	protected override DependencyObject GetContainerForItemOverride()
	{
		return new NaviItem();
	}
}
