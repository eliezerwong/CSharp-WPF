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

namespace WpfClasses
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtImage.Text) == true)
            {
                isValid = false;
                MessageBox.Show("Invalid entry for Image.");
            }

            if (string.IsNullOrWhiteSpace(txtManu.Text) == true)
            {
                isValid = false;
                MessageBox.Show("Invalid entry for Manufactorer.");
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                isValid = false;
                MessageBox.Show("Invalid entry for Name.");
            }

            double price;
            if (double.TryParse(txtPrice.Text, out price) == false)
            {
                isValid = false;
                //txtPrice.Text = ""; // string.Empty;
                MessageBox.Show("Invalid entry for Price.");
            }

            if (isValid == false)
            {
                return;
            }

            //Toy t = new Toy(txtName.Text, txtManu.Text, txtImage.Text, price);
            Toy t = new Toy();
            t.Image = txtImage.Text;
            t.Manufacturer = txtManu.Text;
            t.Name = txtName.Text;
            t.Price = price;

            lstToy.Items.Add(t);
        }

        private void lstToy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstToy.SelectedItem;
            MessageBox.Show(selectedToy.GetAisle());

            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);

            imgBx.Source = img;
        }

        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    string manufactorer, name, price, image;

        //    while (string.IsNullOrWhiteSpace(txtManu.Text) == true || string.IsNullOrWhiteSpace(txtName.Text) == true)
        //    {
        //        MessageBox.Show("Cannot be empty");
        //        break;
        //    }

        //    //while (double.TryParse(txtPrice, out ))
        //    //{

        //    //}

        //    manufactorer = txtManu.Text;
        //    name = txtName.Text;
        //    price = txtPrice.Text;

        //    //var uri = new Uri(https://www.ikea.com/us/en/images/products/knorrig-soft-toy-pig-pink__0710181_pe727384_s5.jpg?f=s);
        //    //var img = new BitmapImage(uri);
        //    //image = 

        //    //Toy toy = new Toy(manufactorer, name, Convert.ToDouble(price), image);

        //    Toy toy = new Toy(manufactorer, name, Convert.ToDouble(price));
        //    lstToy.Items.Add(toy);

        //}

        //private void lstToy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Toy selectedToy = (Toy)lstToy.SelectedItem;


        //    MessageBox.Show($"{selectedToy.Name} from {selectedToy.Manufacturer} can be found on {selectedToy.GetAisle()}");
        //}
    }
}
