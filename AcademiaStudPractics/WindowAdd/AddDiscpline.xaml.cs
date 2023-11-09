using AcademiaStudPractics.BDSHKA;
using AcademiaStudPractics.Pages;
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

namespace AcademiaStudPractics.WindowAdd
{
    /// <summary>
    /// Логика взаимодействия для AddDiscpline.xaml
    /// </summary>
    public partial class AddDiscpline : Window
    {
        public AddDiscpline()
        {
            InitializeComponent();
            var cip = App.BD.Kafedra.ToList();
            CipherCB.ItemsSource = cip.ToList();
            CipherCB.DisplayMemberPath = "cipher";
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            disciplin dis  = new disciplin();
            dis.Kod = Convert.ToInt32(KodTB.Text);
            dis.Volume = Convert.ToInt32(VolumeTB.Text);
            dis.Name = NamesTB.Text.Trim();
            dis.cipher = (CipherCB.SelectedItem as Kafedra).cipher;
            dis.Visible = true;
            App.BD.disciplin.Add(dis);
            App.BD.SaveChanges();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выход без добавления");
            Close();
        }
    }
}
