using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF.Main.Local.ViewModels;
public partial class MainContentViewModel : ObservableBase, IViewLoadable
{
	public MainContentViewModel() { }
	  
	public void OnLoaded(IViewable view)
	{
		Title = "aaaa";
	}

	[ObservableProperty]
	private string _Title;
}
