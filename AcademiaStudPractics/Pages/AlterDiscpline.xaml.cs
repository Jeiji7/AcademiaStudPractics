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
    /// Логика взаимодействия для AlterDiscpline.xaml
    /// </summary>
    public partial class AlterDiscpline : Page
    {
        private disciplin SelItems;
        public AlterDiscpline(disciplin _discpline)
        {
            InitializeComponent();

            var cip = App.BD.Kafedra.ToList();
            CipherCB.ItemsSource = cip.ToList();
            CipherCB.DisplayMemberPath = "cipher";

            SelItems = _discpline;
            NumberTB.Text = Convert.ToString(SelItems.Kod);
            VolumeTB.Text = Convert.ToString(SelItems.Volume);
            NameTB.Text = SelItems.Name;
            CipherCB.Text = SelItems.cipher;

        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            SelItems.Name = NameTB.Text;
            SelItems.Kod = Convert.ToInt32(NumberTB.Text);
            SelItems.Volume = Convert.ToInt32(VolumeTB.Text);
            SelItems.cipher = CipherCB.Text;
            App.BD.SaveChanges();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            SelItems.Visible = false;
            App.BD.SaveChanges();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DiscplineKafedra());
        }
    }
}
