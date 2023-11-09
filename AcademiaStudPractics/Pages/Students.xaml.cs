using AcademiaStudPractics.BDSHKA;
using AcademiaStudPractics.WindowAdd;
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

namespace AcademiaStudPractics.Pages
{
    /// <summary>
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Page
    {
        public Students()
        {
            InitializeComponent();
            StudikList.ItemsSource = App.BD.Student.Where(x => x.Visible == true).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Exams());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new AddStudExams().Show();
        }

        private void DepartmentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (Student)StudikList.SelectedItem;

            DeleteStud editPage = new DeleteStud(selectedItem);
            NavigationService.Navigate(editPage);
        }
    }
}
