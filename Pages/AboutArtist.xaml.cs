using MusicLibrary.Navigator;
using System;
using System.Collections.Generic;
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

namespace MusicLibrary.Pages
{
    /// <summary>
    /// Interaction logic for AboutArtist.xaml
    /// </summary>
    public partial class AboutArtist : UserControl
    {
        public AboutArtist(string name, string ganre, string country, string img)
        {
            InitializeComponent();
            ArtistImage.Source = new BitmapImage(new Uri(img));
            ArtistName.Text = name;
            ArtistGenre.Text = ganre;
            ArtistCountry.Text = country;

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
