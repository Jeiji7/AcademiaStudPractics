using AcademiaStudPractics.BDSHKA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Логика взаимодействия для CreateEmployee.xaml
    /// </summary>
    public partial class CreateEmployee : Page
    {
        public CreateEmployee()
        {
            InitializeComponent();
            var prepod = App.BD.Zav_Kafedra.ToList();
            Number_GlavCB.ItemsSource = prepod.ToList();
            Number_GlavCB.DisplayMemberPath = "ID_employee";


            var Cipher = App.BD.Kafedra.ToList();
            CiperCB.ItemsSource = Cipher.ToList();
            CiperCB.DisplayMemberPath = "cipher";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee()
            {
                ID_employee = Convert.ToInt32(IDTB.Text),
                Surname = NameTB.Text.Trim(),
                Salary = Convert.ToInt32(SalaryTB.Text),
                Post = PostTB.Text.Trim(),
                ID_prepod = (Number_GlavCB.SelectedItem as Zav_Kafedra).ID_employee,
                cipher = (CiperCB.SelectedItem as Kafedra).cipher,
                Visible = true
            };
            App.BD.Employee.Add(employee);
            App.BD.SaveChanges();
            MessageBox.Show("Успешно добавлен!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Inginers());
        }


    }
}
