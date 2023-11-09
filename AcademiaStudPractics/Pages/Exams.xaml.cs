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
    /// Логика взаимодействия для Exams.xaml
    /// </summary>
    public partial class Exams : Page
    {
        public Exams()
        {
            InitializeComponent();
            ExamsList.ItemsSource = App.BD.Exams.ToList();
        }

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Students());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Enter());
        }
    }
}
