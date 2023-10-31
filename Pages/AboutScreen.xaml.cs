using MusicLibrary.Domain;
using MusicLibrary.Navigator;
using System.Diagnostics.Metrics;
using System;
using System.Windows.Controls;
using System.Xml.Linq;

namespace MusicLibrary.Pages
{
    /// <summary>
    /// Interaction logic for AboutScreen.xaml
    /// </summary>
    public partial class AboutScreen : UserControl
    {
        public string Name { get; set; }
        public string Ganre { get; set; }
        public string Country { get; set; }
        public string Img { get; set; }
        public AboutScreen(string name, string ganre, string country, string img)
        {
            InitializeComponent(); 
            Name = name;
            Ganre = ganre;
            Country = country;
            Img = img;
           // 

            ArtistImage.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(img));
            ArtistName.Text = name;
            ArtistGenre.Text = ganre;
            ArtistCountry.Text = country;
            ArtistBackground.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(img));
           
        }
        public AboutScreen Clone()
        {
            return new AboutScreen(Name, Ganre, Country, Img);
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            NavigatorObject.Switch(new HomeScreen());
        }

        private void Button_Click_History(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigatorObject.oldPage = this.Clone();
            NavigatorObject.Switch(new ErrorScreen());

        }

        private void Button_Click_Disco(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigatorObject.oldPage = this.Clone();
            NavigatorObject.Switch(new ErrorScreen());
        }
    }
}
