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
    /// Логика взаимодействия для Request.xaml
    /// </summary>
    public partial class Request : Window
    {
        public Request(int id = 0)
        {
            InitializeComponent();
            fioB.Text = $"{App.currentUser.lastName} {App.currentUser.firstName} {App.currentUser.middleName}";
            emailB.Text = App.currentUser.email;
            phoneNumberB.Text = "+" + App.currentUser.numbers[0].code + App.currentUser.numbers[0].number;
            List<Models.ShortProduct> products = Services.ProductService.GetAllProducts();
            productCb.ItemsSource = products;
            productCb.SelectedItem = products.First(x => x.id == id);
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(fioB.Text) || string.IsNullOrWhiteSpace(emailB.Text) || string.IsNullOrWhiteSpace(phoneNumberB.Text))
            {
                MessageBox.Show("Заполните все поля с личными данными:\n- ФИО (Фамилия Имя Отчество)\n- EMail (Электронная почта) \n- Номер телефона");
                return;
            }
            Models.NewRequest request = new()
            {
                fio = fioB.Text,
                email = emailB.Text,
                comment = commentB.Text,
                phoneNumber = phoneNumberB.Text.Replace("+", String.Empty),
                type = "NEW",
                productId = (productCb.SelectedItem as Models.ShortProduct).id
            };
            try
            {
                Services.RequestService.Send(request);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка сервера!\n" + ex.Message);
            }

            MessageBox.Show("Ваш запрос отправлен!\nНаши менеджеры рассмотрят Ваш запрос и свяжутся с вами по указанным контактным данным.");
        }
    }
}
