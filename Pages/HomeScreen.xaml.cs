using MusicLibrary.Domain;
using MusicLibrary.Navigator;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            artists = new List<Artist>
            {
                new Artist("Five Finger Death Punch", "Heavy metal", "United States", "https://www.fivefingerdeathpunch.com/wp-content/uploads/2020/09/5fdp-2020-press-1.jpg"),
                new Artist("Mercenary", "Melodic death metal", "Denmark", "https://mercenary.dk/wp-content/uploads/2023/02/mercenary.jpg"),
                new Artist("Volbeat", "Heavy metal", "Denmark", "https://www.volbeat.dk/5/media/image/_20190515155357_473_1500.jpg"),
                new Artist("Scar Symmetry", "Melodic death metal", "Sweden", "https://static.wixstatic.com/media/594bf0_5658be592af14251bde9338429b76aaf~mv2.jpg/v1/fill/w_1899,h_838,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/594bf0_5658be592af14251bde9338429b76aaf~mv2.jpg"),
                new Artist("In Flames", "Melodic death metal", "Sweden", "https://www.inflames.com/wp-content/uploads/2020/11/In-Flames-2020-Press-Photo-1.jpg"),
                new Artist("Fall Out Boy", "Pop rock", "United States", "https://www.wheninmanila.com/wp-content/uploads/2023/09/fall-out-boy.jpg")
            };
            LVArtist.ItemsSource = artists;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click_Info(object sender, RoutedEventArgs e)
        {
            var artist = (sender as StackPanel).DataContext as Artist;
            NavigatorObject.Switch(new AboutScreen(artist.Name, artist.Genre, artist.Country, artist.Img));

        }
    }
}
