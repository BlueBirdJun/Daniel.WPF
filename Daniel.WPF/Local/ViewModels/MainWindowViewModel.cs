using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Daniel.WPF.Support.Helpers;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
 

namespace Daniel.WPF.Local.ViewModels;
public partial class MainWindowViewModel : ObservableBase, IViewLoadable
{
	private readonly IContainerProvider _containerProvider;
	private readonly IRegionManager _regionManager;
	private readonly ThemeManager _themeManager;
	private IViewable _view;

	public MainWindowViewModel(IContainerProvider containerProvider, IRegionManager regionManager , ThemeManager theme)
	{
		_containerProvider = containerProvider;
		_regionManager = regionManager; 
		_themeManager = theme;
		_themeManager.RegisterTheme("Dark",  "Daniel.WPF.Support", "Resources/DarkTheme.xaml");
		_themeManager.RegisterTheme("Light", "Daniel.WPF.Support", "Resources/LightTheme.xaml");
		_themeManager.ApplyTheme("Light");
		ThemeText = _isDarkTheme ? "Dark" : "Light";
		 
	}

	public void OnLoaded(IViewable view)
	{
		MaxButtonICon = "Apple";
		_view = view;
		//IRegion mainRegion = _regionManager.Regions["MainRegion"];
		//IViewable mainContent = _containerProvider.Resolve<IViewable>("MainContent");
		//if (!mainRegion.Views.Contains(mainContent))
		//{
		//	mainRegion.Add(mainContent);
		//}
		//mainRegion.Activate(mainContent);
	}

	[ObservableProperty]
	private string _MaxButtonICon;
	[ObservableProperty]
	private string _ThemeText;
	

	[RelayCommand]
	private void Btn(string parameter)
	{
		Window window = Window.GetWindow(_view.View);
		switch (parameter)
		{
			case "Mini":
				window.WindowState = WindowState.Minimized;
				break;
			case "Max":
				if (window.WindowState != WindowState.Maximized)
				{
					MaxButtonICon = "Apple";
					window.WindowState = WindowState.Maximized;
				}
				else
				{
					window.WindowState = WindowState.Normal;
					MaxButtonICon = "Maximize";
				}
				break;
			case "Close":
				if (MessageBox.Show("닫을래", "Explorer", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
				{
					window.Close();
				}
				break;
		}  
	}


	bool _isDarkTheme = false;
	[RelayCommand]
	private void ThemeChange()
	{
		//MessageBox.Show("theme");
		_isDarkTheme= _isDarkTheme?false: true;
		_themeManager.ApplyTheme(_isDarkTheme ? "Dark" : "Light");
		ThemeText = _isDarkTheme ? "Dark" : "Light";
	}

}
