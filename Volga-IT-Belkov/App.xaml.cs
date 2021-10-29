using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Volga_IT_Belkov
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static Models.LoginRespond loginData { get; set; }
		public static Models.User currentUser { get; set; }
	}
}
