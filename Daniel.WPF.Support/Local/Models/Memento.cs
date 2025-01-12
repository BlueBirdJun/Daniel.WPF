using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF.Support.Local.Models
{
	public class Memento
	{
		private string _fullPath;

		public Memento(string fullPath)
		{
			_fullPath = fullPath;
		}

		public string GetSavedFullPath()
		{
			return _fullPath;
		}
	}
}
