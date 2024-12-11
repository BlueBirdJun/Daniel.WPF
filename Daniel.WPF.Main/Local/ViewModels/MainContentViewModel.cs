using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Core;
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

	public void Loaded()
	{
		Title = "aaaa";
	}
	[ObservableProperty]
	private string _Title;
}
