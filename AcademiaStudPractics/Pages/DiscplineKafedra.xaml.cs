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
    /// Логика взаимодействия для DiscplineKafedra.xaml
    /// </summary>
    public partial class DiscplineKafedra : Page
    {
     
        public DiscplineKafedra()
        {
            InitializeComponent();
            //DiscplineList.ItemsSource = App.BD.disciplin.ToList();
            DiscplineList.ItemsSource = App.BD.disciplin.Where(i => i.Visible == true).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ZavDepartmenc());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new WindowAdd.AddDiscpline());
            new AddDiscpline().Show();

        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            //DiscplineList.ItemsSource = App.BD.disciplin.ToList();
            DiscplineList.ItemsSource = App.BD.disciplin.Where(i => i.Visible == true).ToList();
        }

        private void DiscplineList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelItems = (disciplin)DiscplineList.SelectedItem;

            AlterDiscpline editPage = new AlterDiscpline(SelItems);
            NavigationService.Navigate(editPage);
        }
    }
}
