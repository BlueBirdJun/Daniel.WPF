using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Daniel.WPF.Support.UI.Units;

    public class CloseButton : Button
    {
        static CloseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseButton),
                new FrameworkPropertyMetadata(typeof(CloseButton)));
        }

        
    }
