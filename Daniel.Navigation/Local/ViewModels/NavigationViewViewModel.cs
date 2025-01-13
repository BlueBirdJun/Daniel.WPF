using CommunityToolkit.Mvvm.Input;
using Daniel.Navigation.Local.Models;
using Daniel.WPF.Support.Helpers;
using Jamesnet.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Daniel.Navigation.Local.ViewModels
{
    public partial class NavigationViewViewModel//: ViewModelBase, IViewLoadable
    {
		public NavigationViewViewModel() { 
			Naviagetions.Add(new NaviItemModel() { Title = "매인", id=1  ,Depth=1});
			Naviagetions.Add(new NaviItemModel() { Title = "Task1", id = 2, Depth = 2 });
			Naviagetions.Add(new NaviItemModel() { Title = "Task2", id = 3, Depth = 3 });
		}

		public void Loaded()
		{
			
		}

		public ObservableCollection<NaviItemModel> Naviagetions { get; init; }=new ObservableCollection<NaviItemModel>();


		[RelayCommand]
		private void FolderChanged(NaviItemModel naviitem)
		{

			MessageBox.Show(naviitem.id.ToString());
		}
	


	}
}
