﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Daniel.App
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                //.AddInversionModule<HelperModules>()
                //.AddInversionModule<ViewModules>()
                //.AddWireDataContext<WireDataContext>()
                .Run();
        }
    }

}
