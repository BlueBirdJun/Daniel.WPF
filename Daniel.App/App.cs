
using Daniel.App.UI.Views;
using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Daniel.App
{
    internal class App: JamesApplication
    {
        protected override Window CreateShell()
        {
            // Temporary Window instance
            return new MainWindow();
        }
    }
}
