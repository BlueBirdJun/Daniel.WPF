using Jamesnet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF;

internal class BootStrapper : AppBootstrapper
{
	protected override void RegisterViewModels()
	{
		//ViewModelMapper.Register<MainContent, MainContentViewModel>();
		//ViewModelMapper.Register<OptionContent, OptionContentViewModel>();
		//ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
	}
	protected override void RegisterDependencies()
	{
		//Container.RegisterSingleton<IMenuManager, MenuManager>();
		//Container.RegisterSingleton<IFriendDataLoader, FriendDataLoader>();

		//IView mainContent = Container.Resolve<MainContent>();
		//IView subNavContent = Container.Resolve<SubMenuContent>();
		//IView socialContent = Container.Resolve<SocialContent>();
		//IView subMenuContent = Container.Resolve<SubMenuContent>();
		//IView optionMenuContent = Container.Resolve<OptionMenuContent>();

		//Layer.Mapping("MainLayer", mainContent);
		//Layer.Mapping("SubNavLayer", subNavContent);
		//Layer.Mapping("SocialLayer", socialContent);
		//Layer.Mapping("SubMenuLayer", subMenuContent);
		//Layer.Mapping("OptionMenuLayer", optionMenuContent);
	}
	protected override void OnStartup()
	{
	}
}
