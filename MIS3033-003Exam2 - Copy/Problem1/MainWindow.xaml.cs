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

namespace Problem1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// MIS 3033-003 Exam 2
    /// Eliezer Emmanuel Wong (113452682)
    public partial class MainWindow : Window
    {
        //List<Restaurants> allRes = new List<Restaurants>();
        public MainWindow()
        {
            InitializeComponent();

            //get restaurant names
            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("http://pcbstuou.w27.wh-2.com/webservices/3033/api/restaurants/names").Result;
                Restaurants api = JsonConvert.DeserializeObject<Restaurants>(jsonData);

                //add restaurants to list
                foreach (var item in api.restaurants)
                {
                    lstRestaurants.Items.Add(item);
                }

            }
        }

        private void lstRestaurants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //when restaurant selected
            RestaurantInfo selectedRestaurant = (RestaurantInfo)lstRestaurants.SelectedItem;
            //concactanating restaurant id in url
            string url = $"http://pcbstuou.w27.wh-2.com/webservices/3033/api/restaurants?id={selectedRestaurant.id}";

            //get the 2nd api using the concactanated id
            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync(url).Result;
                RestaurantInformation infoApi = JsonConvert.DeserializeObject<RestaurantInformation>(jsonData);
                
                //show the new window
                WndInfo wnd = new WndInfo();
                wnd.ShowInfo(infoApi);
                wnd.ShowDialog();
            }


        }
    }
}
