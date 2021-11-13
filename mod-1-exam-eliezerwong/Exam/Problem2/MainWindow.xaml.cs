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

/// <summary>
/// Eliezer Emmanuel Wong
/// 
/// var uri = new Uri("");
/// var img = new BitmapImage(uri);
/// </summary>
namespace Problem2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Big12> big12 = new List<Big12>();
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("big_12_football_stadiums.txt").Skip(1);

            //run through all lines in file
            foreach (var line in lines)
            {
                //University | Football stadium | Capacity | Logo
                //Baylor|McLane Stadium|45140|https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Baylor_Athletics_logo.svg/150px-Baylor_Athletics_logo.svg.png

                //run through all items in line
                var pieces = line.Split('|');

                //Add values to default
                big12.Add(new Big12() { University = pieces[0], FootballStadium = pieces[1], Capacity = Convert.ToInt32(pieces[2]), Logo = pieces[3] });
            }

            PopCombo(big12);
        }

        /// <summary>
        /// Add each uni item in big12 list to combo
        /// </summary>
        /// <param name="big12"></param>
        private void PopCombo(List<Big12> big12)
        {
            foreach (var sch in big12)
            {
                if (string.IsNullOrWhiteSpace(sch.University) == true)
                {
                    return;
                }

                if (!cboUniversities.Items.Contains(sch.University))
                {
                    cboUniversities.Items.Add(sch.University);
                }
            }
        }

        private void cboUniversities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboUniversities.SelectedValue is null)
            {
                return;
            }

            //if uni matches with cboselection, populate fields
            foreach (var sch in big12)
            {
                if (cboUniversities.SelectedValue.ToString() == sch.University)
                {
                    txtUniversity.Text = sch.University;
                    txtStadium.Text = sch.FootballStadium;
                    txtCapacity.Text = sch.Capacity.ToString();

                    imgLogo.Source = new BitmapImage(new Uri(sch.Logo));
                }
            }
        }
    }
}
