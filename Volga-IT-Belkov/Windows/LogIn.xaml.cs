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
using Newtonsoft.Json;

namespace Volga_IT_Belkov.Windows
{
	/// <summary>
	/// Логика взаимодействия для LogIn.xaml
	/// </summary>
	public partial class LogIn : Window
	{
		public LogIn()
		{
			InitializeComponent();
			if (!Services.ApiService.ValidateConnection())
			{
				MessageBox.Show("Не удалось подключиться к нашим сервисам.\nПожалуйста, повторите попытку позже или свяжитесь с нами!\nhttps://www.simbirsoft.com/");
				this.Close();
			}
		}

		private void LogInBtn_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(loginB.Text) || string.IsNullOrWhiteSpace(passwordB.Password))
			{
				MessageBox.Show("Поля логина и пароля должны быть заполнены!\nЗаполните данные поля и повторите попытку.");
				return;
			}
			try
			{
				Products p = new(Services.UserService.Authorize(loginB.Text, passwordB.Password));
				p.Show();
				this.Close();
			}
			catch (System.Net.WebException ex)
			{
				if (ex.Message.Contains("401"))
					MessageBox.Show("Неправильное имя пользователя или пароль!");
				else 
				{
					MessageBox.Show($"Непредвиденная ошибка:\n{ex.Message}");
				}
			}

		}
	}
}
