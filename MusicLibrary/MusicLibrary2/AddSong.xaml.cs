using Microsoft.Win32;
using MusicLibrary2.Database;
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
            _uc = uc;
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
            string tags = Tags.Text == "" ? "N/O" : Tags.Text;
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string destinationDirectory = System.IO.Path.Combine(projectRoot, "Soundtracks");
            string destinationPath = System.IO.Path.Combine(destinationDirectory, System.IO.Path.GetFileName(selectedFilePath));

            PopUpText.Text = "Song Added to the library!";
            PopUp.Visibility = Visibility.Visible;
            //add song to database
            try
            {
                File.Copy(selectedFilePath, destinationPath, overwrite: true);
                TagLib.File file = TagLib.File.Create(selectedFilePath);
                TimeSpan duration = file.Properties.Duration/2;
                Soundtrack soundtrack = new Soundtrack();
                soundtrack.Filename = System.IO.Path.GetFileName(selectedFilePath);
                soundtrack.DisplayName = title;
                soundtrack.Description = description;
                soundtrack.CategoryID = Database.SoundtrackRepo.GetCategoryID(category);
                soundtrack.Duration = duration.ToString();
                soundtrack.Tags = tags;
                switch (category)
                {
                    case "Folk":
                        Database.SoundtrackRepo.Folk.Add(soundtrack);
                        break;
                    case "Battle":
                        Database.SoundtrackRepo.Battle.Add(soundtrack);
                        break;
                    case "Tavern":
                        Database.SoundtrackRepo.Tavern.Add(soundtrack);
                        break;
                    case "Forest":
                        Database.SoundtrackRepo.Forest.Add(soundtrack);
                        break;
                    case "Cavern":
                        Database.SoundtrackRepo.Cavern.Add(soundtrack);
                        break;
                    case "Night":
                        Database.SoundtrackRepo.Night.Add(soundtrack);
                        break;
                    case "Epic":
                        Database.SoundtrackRepo.Epic.Add(soundtrack);
                        break;
                }
                Database.SoundtrackRepo.AddSoundtrack(soundtrack);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine(ex.Message); // Problem 3 fix
            }

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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            selectedFilePath = files[0];

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