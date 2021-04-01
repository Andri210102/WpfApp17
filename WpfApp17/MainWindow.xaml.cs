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

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Employee
        {
            public string AdressNo { get; set; }
            public string Company { get; set; }
            public string Greeting { get; set; }
            public string Title { get; set; }
            public string Name { get; set; }
            public string FirstName { get; set; }
            public string Street { get; set; }
            public string Country { get; set; }
            public string PostaleCode { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public string DateofBirth { get; set; }
        }
        private void AddNewEmployeeBT_Click(object sender, RoutedEventArgs e)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.AdressNo = AdressNoTB.Text;
            tempEmployee.Company = CompanyTB.Text;
            tempEmployee.Greeting = GreetingTB.Text;
            tempEmployee.Title = TitleTB.Text;
            tempEmployee.Name = NameTB.Text;
            tempEmployee.FirstName = FirstNameTB.Text;
            tempEmployee.Street = StreetTB.Text;
            tempEmployee.Country = CountryTB.Text;
            tempEmployee.PostaleCode = PostaleCodeTB.Text;
            tempEmployee.City = CityTB.Text;
            tempEmployee.Phone = PhoneTB.Text;
            tempEmployee.DateofBirth = DateofBirthTB.Text;

            DataGridXAMLl.Items.Add(tempEmployee);

            

        }
    }
}
