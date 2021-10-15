using Client.AuthenticateReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public LoginPage()
        {
            InitializeComponent();
            registration = new RegistrationPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            registration.Show();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            AuthenticateServiceClient client = new AuthenticateServiceClient();

            int response = client.Login(new LogInDTO { Login = boxUsername.Text, Password = passBox.Password });

            if(response == 0)
            {
                MessageBox.Show("Incorrect password or login");
            }
            else if(response == 1)
            {
                Student_profil_page window = new Student_profil_page();
                window.Show();
                this.Close();
            }
            else
            {
                TeacherCoursesWindow1 window = new TeacherCoursesWindow1(boxUsername.Text);
                window.Show();
                this.Close();
            }
        }
    }
}
