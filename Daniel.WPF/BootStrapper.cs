
using Daniel.Navigation.Local.ViewModels;
using Daniel.Navigation.UI.Views;
using Daniel.WPF.Local.ViewModels;
using Daniel.WPF.Main.Local.ViewModels;
using Daniel.WPF.Main.UI.Views;

using Daniel.WPF.Support.Helpers;
using Daniel.WPF.Task1.Local.ViewModels;
using Daniel.WPF.Task1.UI.Views;
using Daniel.WPF.UI.Views;
using Jamesnet.Core;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Location;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF;

internal class BootStrapper : AppBootstrapper
{
	
	public BootStrapper()
	{
		
	}

	protected override void RegisterViewModels()
	{
		//ViewModelMapper.Register<MainWindows, MainWindowViewModel>();
		//viewmodel
		//items.Register<MainWindows, MainWindowViewModel>();
		

		ViewModelMapper.Register<MainContent, MainContentViewModel>();
		ViewModelMapper.Register<Navigation.UI.Views.NavigationView, NavigationViewViewModel>();

		ViewModelMapper.Register<Task1View, Task1ViewViewModel>();


		//ViewModelMapper.Register<Task1View, Task1ViewViewModel>();
		//ViewModelMapper.Register<MainWindows, MainWindowViewModel>();
		//ViewModelMapper.Register<MainWindows, MainWindowViewModel>();
		//ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
	}
	protected override void RegisterDependencies()
	{
		Container.RegisterSingleton<IView, MainContent>("Main");
		Container.RegisterSingleton<IView, Task1View>("Task1");

		//ServiceModules imo = new ServiceModules();
		//imo.RegisterTypes();
		//Container.RegisterSingleton<IThemeManage,ThemeManager>();
		//var theme = Container.Resolve<IThemeManage>();
		//theme.RegisterTheme("Dark", "Daniel.WPF.Support", "Resources/DarkTheme.xaml");
		//theme.RegisterTheme("Light", "Daniel.WPF.Support", "Resources/LightTheme.xaml");
		//theme.ApplyTheme("Light");
		//Container.Register<MainWindows, MainWindowViewModel>();

		//Container.RegisterSingleton<IMenuManager, MenuManager>();
		//Container.RegisterSingleton<IFriendDataLoader, FriendDataLoader>();

		IView mainContent = Container.Resolve<MainContent>();
		IView navi = Container.Resolve<NavigationView>();
		//IView task1 = Container.Resolve<Task1View>();
		//IView subNavContent = Container.Resolve<SubMenuContent>();
		//IView socialContent = Container.Resolve<SocialContent>();
		//IView subMenuContent = Container.Resolve<SubMenuContent>();
		//IView optionMenuContent = Container.Resolve<OptionMenuContent>();

		Layer.Mapping("MainLayer", mainContent);
		Layer.Mapping("Navigator", navi);
		//Layer.Mapping("Task1", task1);
		//Layer.Mapping("SubNavLayer", subNavContent);
		//Layer.Mapping("SocialLayer", socialContent);
		//Layer.Mapping("SubMenuLayer", subMenuContent);
		//Layer.Mapping("OptionMenuLayer", optionMenuContent);
	}

	public void Match(ViewModelLocatorCollection items)
	{
		//items.RegisterSingleton<IThemeManage,ThemeManager>();
		items.Register<MainWindows, MainWindowViewModel>();
		//items.Register<Navigation.UI.Views.NavigationView, NavigationViewViewModel>();
	}
	protected override void OnStartup()
	{
		//RegisterWireDataContexts
	}

 
 

	

}
