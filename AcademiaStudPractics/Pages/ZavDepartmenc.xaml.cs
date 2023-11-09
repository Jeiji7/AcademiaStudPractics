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
    /// Логика взаимодействия для ZavDepartmenc.xaml
    /// </summary>
    public partial class ZavDepartmenc : Page
    {
        public ZavDepartmenc()
        {
            InitializeComponent();
            DepartmentList.ItemsSource = App.BD.Kafedra.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Enter());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DiscplineKafedra());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Kafedra kafedra = new Kafedra();
            kafedra.cipher = CipherTB.Text.Trim();
            kafedra.Names = NamesTB.Text.Trim();
            kafedra.ID_facuilt = Convert.ToInt32(FacultTB.Text);
            App.BD.Kafedra.Add(kafedra);
            App.BD.SaveChanges();
        }
    }
}
