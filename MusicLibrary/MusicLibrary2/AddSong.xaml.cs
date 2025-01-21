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

namespace MusicLibrary2
{
    /// <summary>
    /// Logika interakcji dla klasy AddSong.xaml
    /// </summary>
    public partial class AddSong : UserControl
    {
        private UserControl _uc;
        public AddSong(UserControl uc)
        {
            InitializeComponent();
            _uc = uc; ;
        }

        private void backClicked (object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(_uc);
        }

        private async void saveClicked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = "Song Added to the library!";
            PopUp.Visibility = Visibility.Visible;
            //add song to database
            /*
             * try {
             * 
             * }
             * catch (Exception ex)
             * {
             * 
             * }
             */
            await Task.Delay(2500);
            PopUp.Visibility = Visibility.Hidden;
            ((MainWindow)Application.Current.MainWindow).NavigateTo(_uc);
        }

        private async void resetClicked(object sender, RoutedEventArgs e)
        {
            Title.Text = "";
            Description.Text = "";
            Tags.Text = "";
            PopUpText.Text = "Prompts reseted";
            PopUp.Visibility = Visibility.Visible;
            await Task.Delay(1500);
            PopUp.Visibility = Visibility.Hidden;
        }
    }
}
