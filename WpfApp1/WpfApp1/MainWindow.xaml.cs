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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Model;
using WpfApp1.Viewmodels;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegistrationViewModel _registrationViewModel { get; set; }
        private FakeDB _dbContext { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _registrationViewModel = new RegistrationViewModel();
            this.DataContext = _registrationViewModel;
            _dbContext = new FakeDB();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_registrationViewModel.Password!=_registrationViewModel.Re_Password)
            {
                MessageBox.Show("Password are different", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
            }
            if (!_registrationViewModel.TermsAccepted)
            {
                MessageBox.Show("You must accept terms", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
            }
            var newUser = new Model.UserAccount()
            {
                Username = _registrationViewModel.Login,
                PasswordHash = _registrationViewModel.Password.ToUpper(),
                Dana_numer_2 = _registrationViewModel.BirthDate,
                TermsAcceptanceDate = DateTime.Now,
                AccountCreateionDate = DateTime.Now

            };
            MessageBox.Show("Added U");
            DataContext = new RegistrationViewModel();



        }
    }
}
