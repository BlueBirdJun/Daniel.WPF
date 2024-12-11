using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF.Support.Local.Models;

public class NaviItem
{
	[ObservableProperty]
	public int _id;
	[ObservableProperty]
	public string _IconName;
	[ObservableProperty]
	public string _Title;
	[ObservableProperty]
	public bool _Visible;
	[ObservableProperty]
	public int _Depth;
}
