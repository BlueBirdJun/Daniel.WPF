using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows;

namespace Daniel.Navigation.UI.Units;
public class ExpandButton : ToggleButton
{
	static ExpandButton()
	{
		DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpandButton),
			 new FrameworkPropertyMetadata(typeof(ExpandButton)));
	}
}
