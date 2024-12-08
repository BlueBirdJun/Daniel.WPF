using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Daniel.WPF.Support.UI.Units;

    public class MaximizeButton:Button
    {
        static MaximizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton),
                 new FrameworkPropertyMetadata(typeof(MaximizeButton)));
        }

    }
