using AcademiaStudPractics.BDSHKA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using AcademiaStudPractics.Pages;
using System.Windows.Navigation;
using System.Windows;

namespace AcademiaStudPractics.Function
{
 
    internal class Registration
    {
        public static List<Employee> worker { get; set; }

        public static Employee AutoRis(string name, string password)
        {
           
            worker = new List<Employee>(App.BD.Employee.ToList());
            Employee currentUser = worker.FirstOrDefault(x => x.Surname == name && Convert.ToString(x.ID_employee) == password);
            if (currentUser != null)
                return currentUser;

            else
                return currentUser;

        }
            
    }
}
