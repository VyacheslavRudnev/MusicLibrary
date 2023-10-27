using MusicLibrary.Domain;
using MusicLibrary.Navigator;
using System.Windows.Controls;
using System.Windows.Media.Animation;


namespace MusicLibrary.Pages
{
    /// <summary>
    /// Interaction logic for ErrorScreen.xaml
    /// </summary>
    public partial class ErrorScreen : UserControl
    {
        public ErrorScreen()
        {
            InitializeComponent();
            lottileObj.FileName = "C:\\Users\\Rudnev V\\source\\repos\\MusicLibrary\\Assets\\ErrorMess.json";
            lottileObj.PlayAnimation();
        }

        private void lottileObj_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //var artist = (sender as Button).DataContext as Artist;  
            //NavigatorObject.Switch(new AboutScreen(artist.Name, artist.Genre, artist.Country, artist.Img));
            NavigatorObject.Switch(new HomeScreen());
        }
    }
}
