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
using AcademiaStudPractics.BDSHKA;


namespace AcademiaStudPractics.Pages
{
    /// <summary>
    /// Логика взаимодействия для DeleteStud.xaml
    /// </summary>
    public partial class DeleteStud : Page
    {
        private Student selectedItem;
        public DeleteStud(Student item)
        {
            InitializeComponent();
            selectedItem = item;

            NumberTB.Text = Convert.ToString(selectedItem.ID_stud);
            NameTB.Text = selectedItem.Surename;

        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Students());
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            selectedItem.Visible = false;
            App.BD.SaveChanges();
            MessageBox.Show("Успешно удалён!");
        }
    }
}
