using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.Navigation.Local.Models;

public class NaviItem
{
 
	public int _id {  get; set; }
	public string _IconName { get; set; }
	public string _Title { get; set; }

	public bool _Visible { get; set; }
	public int _Depth { get; set; }
}
