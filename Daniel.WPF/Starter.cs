using Daniel.WPF.properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel.WPF;
internal class Starter
{
	[STAThread]
	private static void Main(string[] args)
	{
		_ = new AppStarter()
			 //.AddInversionModule<HelperModules>()
			 .AddInversionModule<ViewModules>()
			 .AddWireDataContext<WireDataContext>()
			 .Run();
	}
}
