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
using Newtonsoft.Json;

namespace JsonSerialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<VideoGames> allGames = new List<VideoGames>();
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("all_games.csv").Skip(1);
            foreach (var line in lines)
            {
                var pieces = line.Split(',');
                allGames.Add(new VideoGames() 
                {
                    name = pieces[0].Trim(), 
                    platform = pieces[1].Trim(), 
                    release_date = pieces[2].Trim(), 
                    summary = pieces[3].Trim(), 
                    meta_score = pieces[4].Trim(), 
                    user_review = pieces[5].Trim()
                });
            }

            PopulateLst(allGames);
            PopulateCbo();

            

        }

        private void UpdateListWithFilter()
        {
            if (cboName.SelectedValue is null )
            {
                return;
            };

            List<VideoGames> filteredGames;
            filteredGames = FilterPlatform(allGames);
            PopulateLst(filteredGames);
            lblCount.Content = $"Record Count: {lstGames.Items.Count.ToString("N0")}";
        }

        private List<VideoGames> FilterPlatform(List<VideoGames> allGames)
        {
            List<VideoGames> filter = new List<VideoGames>();
            foreach (var game in allGames)
            {
                if (cboName.SelectedValue.ToString().ToLower() == "all")
                {
                    filter.Add(game);
                }
                else if (cboName.SelectedValue.ToString() == game.platform)
                {
                    filter.Add(game);
                }
            }
            return filter;
        }

        private void PopulateCbo()
        {
            cboName.Items.Add("All");
            cboName.SelectedIndex = 0;

            foreach (var game in allGames)
            {
                if (string.IsNullOrWhiteSpace(game.platform) == true)
                {
                    return;
                }
                else if (!cboName.Items.Contains(game.platform))
                {
                    cboName.Items.Add(game.platform);
                }

            }
        }

        private void PopulateLst(List<VideoGames> allGames)
        {
            lstGames.Items.Clear();
            foreach (var game in allGames)
            {
                lstGames.Items.Add(game);
            }
        }

        private void cboName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateListWithFilter();
        }

        private void lstGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoGames selectedGame = (VideoGames)lstGames.SelectedItem;
            WndGamesDetails info = new WndGamesDetails();
            info.PopulateData(selectedGame);

            info.Show();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstGames.Items, Formatting.Indented);
            File.WriteAllText($"{cboName.SelectedValue.ToString()}_game.json", json);
        }
    }
}
