using CommunityToolkit.Mvvm.Input;
using Daniel.Navigation.Local.Models;
using Daniel.WPF.Support.Helpers;
using Jamesnet.Core;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using IViewLoadable = Jamesnet.Wpf.Controls.IViewLoadable;

namespace Daniel.Navigation.Local.ViewModels
{
    public partial class NavigationViewViewModel: ObservableBase, Jamesnet.Core.IViewLoadable
    { 
		private readonly ILayerManager _layerManager;
		private readonly IContainer _container;

		public NavigationViewViewModel(ILayerManager layerManager, IContainer container)
		{//IContainerProvider containerProvider, IRegionManager regionManager) {
		 //_containerProvider = containerProvider;
		 //_regionManager = regionManager;
			_layerManager = layerManager;
			_container = container;
		}

		

		public ObservableCollection<NaviItemModel> Naviagetions { get; init; }=new ObservableCollection<NaviItemModel>();


		[RelayCommand]
		private void FolderChanged(NaviItemModel naviitem)
		{
			//IRegion mainRegion = _regionManager.Regions["MainRegion"];
			//IViewable mainContent = _containerProvider.Resolve<IViewable>("Task1");
			//if (!mainRegion.Views.Contains(mainContent))
			//{
			//	mainRegion.Add(mainContent);
			//}
			//mainRegion.Activate(mainContent);

			//_container.TryResolve<IView>("Task1", out var view);
			//_layerManager.Show("MainLayer", view);
			//_layerManager.Show("ContentLayer", view);
			//MessageBox.Show(naviitem.id.ToString());
			IView view;
			_layerManager.Hide("MainLayer");
			switch(naviitem.id)
			{
				case 1:
					_container.TryResolve<IView>("Main", out   view);
					_layerManager.Show("MainLayer", view);
					break;
				case 2:
					_container.TryResolve<IView>("Task1", out   view);
					_layerManager.Show("MainLayer", view);
					break;
			}
			 
		}

		 
		public void Loaded()
		{
			Naviagetions.Add(new NaviItemModel() { Title = "매인", id = 1, Depth = 1 });
			Naviagetions.Add(new NaviItemModel() { Title = "Task1", id = 2, Depth = 2 });
			Naviagetions.Add(new NaviItemModel() { Title = "Task2", id = 3, Depth = 3 });
		}
	}
}
