using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Core;

//using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Regions;

namespace Daniel.WPF.Task1.Local.ViewModels;

[RegionMemberLifetime(KeepAlive = false)]
public partial class Task1ViewViewModel : ObservableBase, IViewLoadable
{
	public Task1ViewViewModel() {
	}

	[ObservableProperty]
	private string _TestString; 

	//public void OnLoaded(IViewable view)
	//{
	//	TestString = "aaaa";
	//}

	public void Loaded()
	{
		Random rd = new Random();
		TestString =rd.Next(0,1000)+ "bbbb";
	}
}
