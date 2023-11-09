using AcademiaStudPractics.BDSHKA;
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
    /// Логика взаимодействия для Inginers.xaml
    /// </summary>
    public partial class Inginers : Page
    {
        public static Employee emp = new Employee();
        public Inginers()
        {
            Employee empl = new Employee();
            InitializeComponent();
            InginersList.ItemsSource = App.BD.Employee.Where(i => i.Visible == true).ToList();
           if(empl.ID_employee == empl.ID_prepod) { }
            //    {
            //        ChefCheck.IsChecked = true;
            //    }
            //else
            //    {
            //        ChefCheck.IsChecked = false;
            //    }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Enter());
        }

        private void Button_Click_ADD(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateEmployee());
        }

     

        private void InginersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (Employee)InginersList.SelectedItem;

            AlterEmployee editPage = new AlterEmployee(selectedItem);
            NavigationService.Navigate(editPage);
        }
    }
}
