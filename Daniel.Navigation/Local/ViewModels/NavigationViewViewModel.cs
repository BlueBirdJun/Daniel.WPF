using Daniel.Navigation.Local.Models;
using Jamesnet.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.Navigation.Local.ViewModels
{
    public class NavigationViewViewModel: ViewModelBase, IViewLoadable
    {
		public NavigationViewViewModel() { 
			Naviagetions.Add(new NaviItem() { Title = "매인", id=1  });
			Naviagetions.Add(new NaviItem() { Title = "Task1", id = 2 });
			Naviagetions.Add(new NaviItem() { Title = "Task2", id = 3 });
		}

		public void Loaded()
		{
			
		}

		public ObservableCollection<NaviItem> Naviagetions { get; init; }=new ObservableCollection<NaviItem>();

	}
}
