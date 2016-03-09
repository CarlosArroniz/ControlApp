using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ControlApp
{
	public partial class AppControl : Application
	{
		public AppControl ()
		{
			InitializeComponent ();
		    MainPage = new Login();
		}
	}
}
