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

/// <summary>
/// Eliezer Emmanuel Wong
/// </summary>
namespace Problem1
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Validate data
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                isValid = false;
                MessageBox.Show("Please enter valid Name");
            }

            DateTime date;
            if (DateTime.TryParse(txtDate.Text, out date) == false)
            {
                isValid = false;
                MessageBox.Show("Please enter valid Date");
            }

            if (string.IsNullOrWhiteSpace(txtBreed.Text) == true)
            {
                isValid = false;
                MessageBox.Show("Please enter valid Breed");
            }

            if (isValid == false)
            {
                return;
            }

            //Add entry to default constructor
            Puppy puppy = new Puppy() { Name = txtName.Text, DateOfBirth = date, Breed = txtBreed.Text};

            //Add object to list
            lstPuppies.Items.Add(puppy);

            //clear all txt
            txtName.Clear();
            txtDate.Clear();
            txtBreed.Clear();
        }
    }
}
