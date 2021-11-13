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

namespace Participation_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblOutput.Visibility = Visibility.Hidden;



        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string dob = txtDOB.Text;
            DateTime birthDate = Convert.ToDateTime(dob);
            TimeSpan age = DateTime.Now - birthDate;

            string name = txtName.Text;



            //MessageBox.Show((age.TotalDays / 365).ToString());

            double old = age.TotalDays / 365;
            lblOutput.Content = $"Hello {name}, you are {old.ToString("N0")}";
            lblOutput.Visibility = Visibility.Visible;
        }

        private void btnSubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            //Window.Background = Brushes.Yellow;
        }
    }
}
