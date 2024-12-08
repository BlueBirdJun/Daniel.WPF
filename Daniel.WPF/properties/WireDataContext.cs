
using Daniel.WPF.Local.ViewModels;
using Daniel.WPF.UI.Views;
using Jamesnet.Wpf.Global.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF.properties;
internal class WireDataContext : ViewModelLocationScenario
{
	protected override void Match(ViewModelLocatorCollection items)
	{

		//items.Register<DarkWindow, DarkWindowViewModel>();
		//items.Register<MainContent, MainContentViewModel>();
		items.Register<MainWindows, MainWindowViewModel>();
	}
}