using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

namespace JsonChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cboJokes.Items.Add("All");
            cboJokes.SelectedIndex = 0;

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;

                List<string> api = JsonConvert.DeserializeObject<List<string>>(jsonData);

                foreach (var item in api)
                {
                    if (string.IsNullOrWhiteSpace(item) == true)
                    {
                        return;
                    }

                    if (!cboJokes.Items.Contains(item))
                    {
                        cboJokes.Items.Add(item);
                        Categories cat = new Categories();
                        cat.Category.Add(item);
                    }
                }
            }


        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            string category = cboJokes.SelectedValue.ToString();

            string url = $"https://api.chucknorris.io/jokes/random?category={category}";

            using (var client = new HttpClient())
            {
                string jsonJokes = client.GetStringAsync("https://api.chucknorris.io/jokes/random?category={Category}").Result;

                var apiJokes = JsonConvert.DeserializeObject<List<string>>(jsonJokes);

                if (cboJokes.SelectedValue.ToString().ToLower() == "all")
                {
                    string jsonAll = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;
                    var apiAll = JsonConvert.DeserializeObject<List<string>>(jsonAll);
                    txbJoke.Text = apiAll.ToString();
                }
                else if (apiJokes.Contains())
                {

                }

            }
        }
    }
}
