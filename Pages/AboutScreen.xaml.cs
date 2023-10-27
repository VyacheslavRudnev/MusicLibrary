using MusicLibrary.Domain;
using MusicLibrary.Navigator;
using System.Windows.Controls;

namespace MusicLibrary.Pages
{
    /// <summary>
    /// Interaction logic for AboutScreen.xaml
    /// </summary>
    public partial class AboutScreen : UserControl
    {
        public AboutScreen(string name, string ganre, string country, string img)
        {
            InitializeComponent();
            ArtistImage.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(img));
            ArtistName.Text = name;
            ArtistGenre.Text = ganre;
            ArtistCountry.Text = country;
            ArtistBackground.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(img));
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeScreen());
        }

        private void Button_Click_History(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigatorObject.Switch(new ErrorScreen());
        }

        private void Button_Click_Disco(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigatorObject.Switch(new ErrorScreen());
        }
    }
}
