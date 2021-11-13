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

namespace Vowels_and_Consonants
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

        //private void txtWord_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    txtWord.Clear();
        //}

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Consonants.Items.Clear();
            Vowels.Items.Clear();
            foreach (char letter in txtWord.Text.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    Vowels.Items.Add(letter);

                }
                else
                {
                    Consonants.Items.Add(letter);
                }


            }

            txtWord.Clear();
            //txtWord.Text = string.Empty;

        }

        
    }
}
