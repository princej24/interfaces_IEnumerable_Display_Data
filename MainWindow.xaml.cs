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

namespace interfaces_IEnumerable_Display_Data
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
        private void BtnDisplay_Click(object sender, RoutedEventArgs e)
        {
            SchoolClass schoolClass = new SchoolClass("Class A");
            List<string> studentNames = new List<string>()
            {
                "John", "Emma", "Michael", "Olivia", "William", "Sophia", "James", "Ava",
                "Benjamin", "Isabella", "Alexander", "Mia", "Daniel", "Charlotte", "Matthew",
                "Amelia", "Joseph", "Harper", "Henry", "Emily"
            };

            foreach (string name in studentNames)
            {
                Student student = new Student(name);
                schoolClass.AddStudent(student);
            }


            string rosterString = "";
            foreach (Student student in schoolClass)
            {
                rosterString += student.ToString() + "\n";
            }
            MessageBox.Show(rosterString, "Class Roster");
        }

    }
    
}
