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
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameF.Text) || string.IsNullOrWhiteSpace(lastNameF.Text) || string.IsNullOrWhiteSpace(emailF.Text))
            {
                MessageBox.Show("Поля Фамилии, Имени и Email-а не могут быть пустыми!");
                return;
            }
        }
    }
}
