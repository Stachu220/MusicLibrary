using Microsoft.Win32;
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

namespace MusicLibrary2
{
    public partial class AddSong : UserControl
    {
        private UserControl _uc;
        private string selectedFilePath;
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
            string title = Title.Text;
            string description = Description.Text;
            string category = CatCombo.Text;
            string tags = Tags.Text;

            PopUpText.Text = "Song Added to the library!" + title + "\n" + description + "\n" + category + "\n" + tags;
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

        private void onFileDrop(object sender, DragEventArgs e)
        {
            selectedFilePath = (string)e.Data.GetData(DataFormats.FileDrop);

            SelectedFile.Text = selectedFilePath;
        }

        private void browseClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Audio Files|*.mp3;*.wav;*.flac;*.aac|All Files|*.*", // Filter for audio files
                Multiselect = false //only one file
            };

            if (openFileDialog.ShowDialog() == true)
            {
                selectedFilePath = openFileDialog.FileName;
                SelectedFile.Text = selectedFilePath;
            }
        }
    }
}