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

namespace In_class_example
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

        private void txtbxid_Copy6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id, fName, lName, probation, gpa, balance;
            
            id = txtid.Text;
            fName = txtFN.Text;
            lName = txtLN.Text;
            //probation = txtProbation.Text;
            gpa = txtGPA.Text;
            balance = txtBB.Text;

            Student stud = new Student(Convert.ToInt32(id), fName, lName, Convert.ToDouble(balance));
            stud.GPA = Convert.ToDouble(gpa);
            stud.IsOnProbation = chkProbation.IsChecked.Value;
            //if (probation.ToLower() == "yes")
            //{
            //    stud.IsOnProbation = true;
            //}
            //else
            //{
            //    stud.IsOnProbation = false;
            //}

            Student.Items.Add(stud);


        }

        private void Student_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedStudent = (Student)Student.SelectedItem;

            MessageBox.Show($"{selectedStudent.FirstName} has a {selectedStudent.GPA.ToString("N0")} GPA");
        }
    }
}
