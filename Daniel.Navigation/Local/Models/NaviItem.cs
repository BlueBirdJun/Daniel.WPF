﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.Navigation.Local.Models;

public class NaviItem
{
 
	public int id {  get; set; }
	public string IconName { get; set; }
	public string Title { get; set; }

	public bool Visible { get; set; }
	public int Depth { get; set; }
}
