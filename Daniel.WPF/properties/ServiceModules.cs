using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF.properties;

public class ServiceModules : IModule
{
	public void OnInitialized(IContainerProvider containerProvider)
	{

	}
	public void RegisterTypes(IContainerRegistry containerRegistry)
	{
		//containerRegistry.RegisterSingleton<ColorManager>();
		//containerRegistry.RegisterSingleton<DirectoryManager>();
		//containerRegistry.RegisterSingleton<FileService>();
		//containerRegistry.RegisterSingleton<NavigatorService>();
	}
}

