using System;
using System.Collections.Generic;
using System.IO;
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

namespace JsonGOT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GotApi> GotQuotes = new List<GotApi>();
        GotApi api = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://got-quotes.herokuapp.com/quotes").Result;
                api = JsonConvert.DeserializeObject<GotApi>(jsonData);
                GotQuotes.Add(api);

                txtName.Text = api.character;
                txbQuote.Text = api.quote;
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
                string json = JsonConvert.SerializeObject(GotQuotes);
                File.WriteAllText("GOT_Quotes.json", json);
        }
    }
}
