using Daniel.WPF.properties;
using Daniel.WPF.Support.Helpers;
using Daniel.WPF.UI.Views;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using System.Windows;

namespace Daniel.WPF;
public partial class App : JamesApplication
{
	public App()
	{
		AddInversionModule<ServiceModules>();
		AddInversionModule<ViewModules>();
		AddWireDataContext<WireDataContext>();
		Run();
	}
	protected override Window CreateShell()
	{
		var theme = Container.Resolve<ThemeManager>();
		theme.RegisterTheme("Dark",  "Daniel.WPF.Support", "Resources/DarkTheme.xaml");
		theme.RegisterTheme("Light", "Daniel.WPF.Support", "Resources/LightTheme.xaml");
		theme.ApplyTheme("Light");
		return new MainWindows();
	}
}
