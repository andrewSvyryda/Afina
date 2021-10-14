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

namespace Client
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        RegistrationPage registration;
        TeacherProfilPage profilPage;
        public LoginPage()
        {
            InitializeComponent();
            registration = new RegistrationPage();
            profilPage = new TeacherProfilPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            profilPage.Show();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            registration.Show();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
