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

namespace JsonPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1200";
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    pokeAll api = JsonConvert.DeserializeObject<pokeAll>(json);

                    foreach (var item in api.results)
                    {
                        cboPoke.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"ERROR: {response.StatusCode}");
                    return;
                }
            }
        }

        private void cboPoke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultItem selected = (ResultItem)cboPoke.SelectedItem;

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(selected.url).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    pokemon poke = JsonConvert.DeserializeObject<pokemon>(json);

                    imgSprite.Source = new BitmapImage(new Uri(poke.sprites.front_default));
                    //showFront = false;
                }

            }
        }

        private void btnFlip_Click(object sender, RoutedEventArgs e)
        {
            //if (true)
            //{
            //    imgSprite.Source = new BitmapImage(new Uri(poke.sprites.front_default));

            //}
        }
    }
}
