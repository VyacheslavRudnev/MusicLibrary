using MusicLibrary.Domain;
using MusicLibrary.Navigator;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MusicLibrary.Pages
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : UserControl
    {
        List<Artist> artists;
        public HomeScreen()
        {
            InitializeComponent();
            artists = new List<Artist>();
            artists.Add(new Artist("Five Finger Death Punch", "Heavy metal", "United States", "https://fivefingerdeathpunch.com/cdn/shop/files/IMG_6428_1242x1233_crop_center.jpg?v=1627411309"));
            artists.Add(new Artist("Mercenary", "Melodic death metal", "Denmark", "https://mercenary.dk/wp-content/uploads/2023/02/mercenary.jpg"));
            artists.Add(new Artist("Volbeat", "Heavy metal", "Denmark", "https://www.volbeat.dk/5/media/image/_20190515155357_473_1500.jpg"));
            artists.Add(new Artist("Scar Symmetry", "Melodic death metal", "Sweden", "https://static.wixstatic.com/media/594bf0_5658be592af14251bde9338429b76aaf~mv2.jpg/v1/fill/w_1899,h_838,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/594bf0_5658be592af14251bde9338429b76aaf~mv2.jpg"));
            artists.Add(new Artist("In Flames", "Melodic death metal", "Sweden", "https://images.squarespace-cdn.com/content/v1/57f2b82b29687fb32444a615/1497464032325-WUG4QVF0LW6RTPRPXTEU/SRF.1-86.jpg?format=2500w"));
            artists.Add(new Artist("Fall Out Boy", "Pop rock", "United States", "https://www.wheninmanila.com/wp-content/uploads/2023/09/fall-out-boy.jpg"));
            LVArtist.ItemsSource = artists;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click_Info(object sender, RoutedEventArgs e)
        {
            var artist = (sender as Button).DataContext as Artist;
            NavigatorObject.Switch(new AboutScreen(artist.Name, artist.Genre, artist.Country,artist.Img));
        }

       
    }
}
