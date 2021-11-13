using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace WPFContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads";

            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = path;
            //ofd.ShowDialog();

            string[] lines = File.ReadAllLines("contacts.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                //0      1          2           3       4
                //Id | FirstName | LastName | Email | Photo
                
                string[] pieces = lines[i].Split('|');
                Contact c = new Contact(Convert.ToInt32(pieces[0]), pieces[1], pieces[2], pieces[3], pieces[4]);
                //c.FirstName = pieces[1];
                //c.LastName = pieces[2];
                //c.Email = pieces[3];
                //c.Image = pieces[4];

                lstContacts.Items.Add(c);

            }
        }

        
        private void btnFilePath_Click(object sender, RoutedEventArgs e)
        {
            

          
        }
    }
}
