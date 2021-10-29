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
using System.Threading;
using System.Diagnostics;

namespace Volga_IT_Belkov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        private Models.Banner banner;
        public Products(Models.LoginRespond _loginData)
        {
            InitializeComponent();
            App.loginData = _loginData;
            banner = Services.BannerService.GetBanner();
            adBanner.Source = new BitmapImage(new Uri(banner.imageUri, UriKind.Relative));
            adBannerTitle.Content = banner.name;
            adBannerDescription.Text = banner.description;

            App.currentUser = Services.UserService.GetUser(App.loginData.userId);
            Avatar.Source = new BitmapImage(new Uri(App.currentUser.imageUri, UriKind.Relative));
            UserName.Content = App.currentUser.firstName + " " + App.currentUser.lastName;


            if (banner == null)
            {
                adBannerBody.Visibility = Visibility.Collapsed;
            }
            ProductsLb.ItemsSource = Services.ProductService.GetAllProducts();
        }

        private void AdBanner_MouseDown(object sender, MouseButtonEventArgs e)
        {
            using (Process bannerOpener = new Process())
            {
                bannerOpener.StartInfo.FileName = banner.url;
                bannerOpener.StartInfo.UseShellExecute = true;
                bannerOpener.Start();
            }
        }

        private void ProductsLb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Вы выбрали {ProductsLb.SelectedIndex}");
        }

        private void UserInfoSp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PersonalInfo p = new();
            p.ShowDialog();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            LogIn l = new();
            l.Show();
            this.Close();
        }
    }
}
