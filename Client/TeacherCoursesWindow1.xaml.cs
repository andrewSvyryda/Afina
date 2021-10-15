using Client.CourseServiceReference;
using Client.UserService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TeacherCoursesWindow1.xaml
    /// </summary>
    public partial class TeacherCoursesWindow1 : Window
    {
        UserServiceClient userServiceClient = new UserServiceClient();
        CourseServiceClient courseServiceClient = new CourseServiceClient();
        TeacherDTO teacher = new TeacherDTO();
        ObservableCollection<CourseServiceReference.CourseDTO> courses = new ObservableCollection<CourseServiceReference.CourseDTO>();
        public TeacherCoursesWindow1(string login)
        {
            teacher = userServiceClient.GetTeacherByLogin(login);

            courses = new ObservableCollection<CourseServiceReference.CourseDTO>(courseServiceClient.GetCoursesByTeacherId(teacher.Id));

            InitializeComponent();

            listSubscriptions.ItemsSource = courses;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            this.Close();
        }

        private void btnUnsubscribe_Click(object sender, RoutedEventArgs e)
        {
            courseServiceClient.CreateCourse(new CourseServiceReference.CourseDTO
            {
                Id = teacher.Id,
                Title = boxTitle.Text,
                Description = boxDiscription.Text
            });

            listSubscriptions.ItemsSource = null;
            courses = new ObservableCollection<CourseServiceReference.CourseDTO>(courseServiceClient.GetCoursesByTeacherId(teacher.Id));
            listSubscriptions.ItemsSource = courses;
        }

        private void btnNewCourse_Click(object sender, RoutedEventArgs e)
        {
            CourseServiceReference.CourseDTO course = (CourseServiceReference.CourseDTO)listSubscriptions.SelectedItem;

            if (course == null)
            {
                return;
            }

            courseServiceClient.ChangeCourse(course.Id, new CourseServiceReference.CourseDTO
            {
                Title = boxTitle.Text,
                Description = boxDiscription.Text
            });

            listSubscriptions.ItemsSource = null;
            courses = new ObservableCollection<CourseServiceReference.CourseDTO>(courseServiceClient.GetCoursesByTeacherId(teacher.Id));
            listSubscriptions.ItemsSource = courses;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CourseServiceReference.CourseDTO course = (CourseServiceReference.CourseDTO)listSubscriptions.SelectedItem;
            
            if (course == null)
            {
                return;
            }

            if(courseServiceClient.DeleteCourse(course.Id))
            {
                courses.Remove(course);
            }
        }
    }
}
