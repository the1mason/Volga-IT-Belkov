using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Volga_IT_Belkov.Windows
{
	/// <summary>
	/// Логика взаимодействия для PersonalInfo.xaml
	/// </summary>
	public partial class PersonalInfo : Window
	{
		public PersonalInfo()
		{
			InitializeComponent();			
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
