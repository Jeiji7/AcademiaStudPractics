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
using AcademiaStudPractics.Function;
using System.IO;
using System.Drawing;

namespace AcademiaStudPractics.Pages
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    

    public partial class Enter : Page
    {
        //public static List<Employee> worker { get; set; }
        public static Employee employee;

        public Enter()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password =PasswordPB.Password;

            
            employee = Registration.AutoRis(login, password);
            if (employee != null)
            {
                if (employee.Post == "зав. кафедрой")
                {
                    NavigationService.Navigate(new ZavDepartmenc());
                }
                else if (employee.Post == "преподаватель")
                {
                    NavigationService.Navigate(new Exams());
                }
                else if (employee.Post == "инженер")
                {
                    NavigationService.Navigate(new Inginers());
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны");
            }
        }

        private void Button_Click_Guest(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Discpline());
        }

        private void Button_Click_QrCode(object sender, RoutedEventArgs e)
        {
            // Ссылка на XL таблицу
            string soucer_xl = "https://docs.google.com/spreadsheets/d/1uB4A6tjRkBLLvngb0xesEQvL3rYHJSGKK0lGPZlTnxU/edit?pli=1#gid=0";
            // Создание переменной библиотеки QRCoder
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            // Присваеваем значиения
            QRCoder.QRCodeData data = qr.CreateQrCode(soucer_xl, QRCoder.QRCodeGenerator.ECCLevel.L);
            // переводим в Qr
            QRCoder.QRCode code = new QRCoder.QRCode(data);
            Bitmap bitmap = code.GetGraphic(100);
            /// Создание картинки
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
                imageQr.Source = bitmapimage;
            }
        }
    }
}
