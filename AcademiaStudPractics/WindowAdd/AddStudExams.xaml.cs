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
using System.Windows.Shapes;

namespace AcademiaStudPractics.WindowAdd
{
    /// <summary>
    /// Логика взаимодействия для AddStudExams.xaml
    /// </summary>
    public partial class AddStudExams : Window
    {
        public AddStudExams()
        {
            InitializeComponent();

            var nums = App.BD.disciplin.ToList();
            NumberCB.ItemsSource = nums.ToList();
            NumberCB.DisplayMemberPath = "Kod";

            var numStud = App.BD.Student.ToList();
            StudCB.ItemsSource = numStud.ToList();
            StudCB.DisplayMemberPath = "ID_stud";

            var prep = App.BD.Employee.Where(x => x.Post == "зав. кафедрой" || x.Post == "преподаватель").ToList();
            EmployeeCB.ItemsSource = prep.ToList();
            EmployeeCB.DisplayMemberPath = "ID_employee";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Exams exam = new Exams()
            {
                ID_exam = Convert.ToInt32(IDTB.Text.Trim()),
                date = DateDP.DisplayDate,
                Kod = (NumberCB.SelectedItem as disciplin).Kod,
                Id_stud = (StudCB.SelectedItem as Student).ID_stud,
                Tab_number = (EmployeeCB.SelectedItem as Employee).ID_employee,
                Atmetk = Convert.ToInt32(AtmetkaTB.Text.Trim()),
                Auditor = AuditorTB.Text.Trim(),
                Visiable = true
            };
            App.BD.Exams.Add(exam);
            App.BD.SaveChanges();

            MessageBox.Show("Успешно добаили, не забудте вернуться на старницу экзамен чтобы увидеть изменения");
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Операция отменена");
            Close();
        }
    }
}
