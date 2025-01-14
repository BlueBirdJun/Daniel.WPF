using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Daniel.WPF.Task1.UI.Units;
public class PlayButton :Button
{
	static PlayButton()
	{
		DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayButton),
				  new FrameworkPropertyMetadata(typeof(PlayButton)));
	}
}
