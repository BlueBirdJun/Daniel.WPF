using Daniel.WPF.Main.UI.Views;
using Jamesnet.Core;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF.properties;
internal class ViewModules : IModule
{
	public void OnInitialized(IContainerProvider containerProvider)
	{
	}

	public void RegisterTypes(IContainerRegistry containerRegistry)
	{
		//containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
		containerRegistry.RegisterSingleton<IView, Daniel.WPF.Main.UI.Views.MainContent>();
		containerRegistry.RegisterSingleton<IView, Daniel.Navigation.UI.Views.NavigationView>();
		
		//IView mainContent = containerRegistry.Resolve<Daniel.WPF.Main.UI.Views.MainContent>();

		//IView mainContent = Container.Resolve<MainContent>();
		//IView naviContent = Container.Resolve<Navigation.UI.Views.Navigation>();
	}
}