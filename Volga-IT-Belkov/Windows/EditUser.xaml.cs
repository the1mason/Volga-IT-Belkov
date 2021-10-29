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
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        public EditUser()
        {
            InitializeComponent();
            firstNameF.Text = App.currentUser.firstName;
            lastNameF.Text = App.currentUser.lastName;
            middleNameF.Text = App.currentUser.middleName;
            emailF.Text = App.currentUser.email;
            birthDateF.Text = App.currentUser.birthday.ToString("dd-MM-yyyy");
            passportSeriesF.Text = App.currentUser.passportSeries;
            passportNumberF.Text = App.currentUser.passportNumber;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameF.Text) || string.IsNullOrWhiteSpace(lastNameF.Text) || string.IsNullOrWhiteSpace(emailF.Text))
            {
                MessageBox.Show("Поля Фамилии, Имени и Email-а не могут быть пустыми!");
                return;
            }
            if (string.IsNullOrWhiteSpace(passportSeriesF.Text) || string.IsNullOrWhiteSpace(passportNumberF.Text))
            {
                MessageBox.Show("Поля серии и номера паспорта не могут быть пустыми!");
                return;
            }
            if (string.IsNullOrWhiteSpace(birthDateF.Text))
            {
                MessageBox.Show("Поле даты рождения не может быть пустым");
                return;
            }

            Models.EditUserRequest request = new()
            {
                birthday = birthDateF.Text,
                firstName = firstNameF.Text,
                lastName = lastNameF.Text,
                middleName = middleNameF.Text,
                numbers = App.currentUser.numbers,
                passportSeries = passportSeriesF.Text,
                passportNumber = passportNumberF.Text
            };
            try
            {
                Services.UserService.EditUser(request);
                
            }
            catch(Exception ex)
            {
                
            }

            MessageBox.Show("Данные обновлены!");
            this.Close();

        }
    }
}
