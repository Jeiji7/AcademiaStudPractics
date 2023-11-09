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
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AlterEmployee : Page
    {
        private Employee selectedItem;
        public AlterEmployee(Employee item)
        {
            InitializeComponent();

            selectedItem = item;
            NamesTB.Text = selectedItem.Surname;
            SalaryTB.Text = Convert.ToString(selectedItem.Salary);
            NumberTB.Text = Convert.ToString(selectedItem.ID_employee);
            PostTB.Text = selectedItem.Post;
            NumberTB.IsReadOnly = true;
        }


        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            selectedItem.Surname = NamesTB.Text;
            selectedItem.Salary = Convert.ToDecimal(SalaryTB.Text);
            //selectedItem.ID_employee = Convert.ToInt32(NumberTB.Text);
            selectedItem.Post = PostTB.Text;
            App.BD.SaveChanges();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Inginers());
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            selectedItem.Visible = false;
            App.BD.SaveChanges();

        }
    }
}
