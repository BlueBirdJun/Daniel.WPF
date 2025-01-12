using Daniel.WPF.Support.Local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF.Support.Helpers
{
    public class NavigatorService
    {
		private Stack<Memento> backStack =new Stack<Memento>();
		public Stack<Memento>  forwardStack =new Stack<Memento>();



		public NavigatorService() { }
    }
}
