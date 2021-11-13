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
using System.IO;

namespace WPF_Files
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

        //comma seperated value since excel columns are seperated by commas on (notepad)
        private void btnReadFIle_Click(object sender, RoutedEventArgs e)
        {
            string file = txtFilePath.Text;

            if (File.Exists(file) == false)
            {
                MessageBox.Show("Invalid file. Please enter a valid file & path.");
                txtFilePath.Clear();
                return;
            }

            string[] contents = File.ReadAllLines(file);

            for (int i = 1; i < contents.Length; i++)
            {
                string line = contents[i];
                //0	1	2	3	4	5	6	7	8	9	10	11
                //



                string[] pieces = line.Split(",");

                string paymentType = pieces[3];

                if (paymentType == "Mastercard")
                {
                    listLines.Items.Add(line);
                }
            }

        }

        private void btnWriteFIle_Click(object sender, RoutedEventArgs e)
        {
            string file = @"C: \Users\eliez\Downloads\output.txt";

            string contents = "This is my file.";

            File.WriteAllText(file, contents);

            string file2 = @"C:\Users\eliez\Downloads\output2.txt";

            string[] output = new string[listLines.Items.Count];
            for (int i = 0; i < listLines.Items.Count; i++)
            {
                output[i] = (string)listLines.Items.Add;
            }
        }
    }
}
