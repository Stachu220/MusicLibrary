using LibVLCSharp.Shared;
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
    /// <summary>
    /// Logika interakcji dla klasy EpicCategory.xaml
    /// </summary>
    public partial class EpicCategory : UserControl
    {
        private bool init = true;
        private int page = 0;
        private TimeSpan interval;
        public EpicCategory()
        {
            init = true;
            page = 0;
            InitializeComponent();

            volSlider.Value = ViewModel.Player.vol / 10;
            init = false;
            if (Database.SoundtrackRepo.Epic.Count() > 8)
            {
                CreateCircularButtons(myCanva, 8, 100);
            }
            else
            {
                CreateCircularButtons(myCanva, Database.SoundtrackRepo.Epic.Count(), 100);
            }
        }
        private void CreateCircularButtons(Canvas canvas, int buttonCount, double radius)
        {
            double centerX = canvas.Width / 2;
            double centerY = canvas.Height / 2;

            for (int i = 0; i < buttonCount; i++)
            {
                double angle = i * (360.0 / buttonCount) * Math.PI / 180; // Convert degrees to radians
                double x = centerX + radius * Math.Cos(angle);
                double y = centerY + radius * Math.Sin(angle);
                Soundtrack soundtrack = SoundtrackRepo.Epic[i];

                // Calculate button width based on the angle (wider on the outside, thinner on the inside)
                double buttonWidth = 50 + (radius - 50) * Math.Abs(Math.Cos(angle)); // This adjusts the width dynamically
                double buttonHeight = 50 + (radius - 50) * Math.Abs(Math.Sin(angle)); // You can adjust height as well
                TextBlock textBlock = new TextBlock
                {
                    Text = soundtrack.DisplayName,
                    TextWrapping = TextWrapping.Wrap,
                    MaxWidth = buttonWidth // Set max width to prevent overflow
                };

                Button button = new Button
                {
                    Content = textBlock,
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Style = (Style)FindResource("SoundtrackButton"),
                    Tag = soundtrack
                };
                button.Click += loadSoundtrack;

                Canvas.SetLeft(button, x - buttonWidth / 2); // Adjust for button width
                Canvas.SetTop(button, y - buttonHeight / 2); // Adjust for button height

                canvas.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void goToAdd(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new AddSong(this));
        }

        private void goToFolk(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new FolkCategory());
        }

        private void goToBattle(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new BattleCategory());
        }

        private void goToTavern(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new TavernCategory());
        }

        private void goToCavern(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new CavernCategory());
        }

        private void goToForest(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new ForestCategory());
        }

        private void goToNight(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new NightCategory());
        }

        private void loadSoundtrack(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Soundtrack soundtrack)
            {
                Title.Text = soundtrack.DisplayName;
                Description.Text = soundtrack.Description;
                Tags.Text = string.Join(", ", soundtrack.Tags);
                ViewModel.Player.TempTitle = soundtrack.Filename;

                interval = TimeSpan.Parse(soundtrack.Duration);
            }
        }

        private void onRemoveClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Soundtrack soundtrack)
            {
                Database.SoundtrackRepo.RemoveSoundtrack(soundtrack);

                for (int i = 0; i < SoundtrackRepo.Forest.Count(); i++)
                {
                    if (SoundtrackRepo.Forest[i] == soundtrack)
                    {
                        SoundtrackRepo.Forest[i] = SoundtrackRepo.Forest.Last();
                        break;
                    }
                }
                SoundtrackRepo.Forest.RemoveAt(SoundtrackRepo.Forest.Count() - 1);
                ((MainWindow)Application.Current.MainWindow).NavigateTo(new ForestCategory());
                string dirSoundtracks = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "\\Soundtracks";
                File.Delete(dirSoundtracks + "\\" + soundtrack.Filename);
            }
        }
        private void onPlayPauseClicked(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Player.Instance.IsPlaying)
            {
                ViewModel.Player.Instance.Stop();
                playPauseButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/play.png"));
            }
            else
            {
                ViewModel.Player.Instance.Play();
                playPauseButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/pause.png"));

                var timer = new System.Windows.Threading.DispatcherTimer
                {
                    Interval = interval
                };

                timer.Tick += (s, args) =>
                {
                    if (playPauseButton.Source == new BitmapImage(new Uri("pack://application:,,,/Images/pause.png")) || LoopToggle.IsChecked == false)
                    {
                        playPauseButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/play.png"));
                    }
                    timer.Stop();
                };

                timer.Start();
            }
        }


        private void onVolumeChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!init)
                ViewModel.Player.Instance.SetVolume((int)volSlider.Value * 10);
        }

        private void onLoop(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Player.IsLoop)
            {
                ViewModel.Player.IsLoop = false;
            }
            else
            {
                ViewModel.Player.IsLoop = true;
            }
        }

        private void RemoveCircularButtons(Canvas canvas)
        {
            // Find all buttons in the canvas except the PPButton
            var buttonsToRemove = canvas.Children
                .OfType<Button>()
                .Where(button => button != PPButton) // Skip the PPButton
                .ToList();

            foreach (var button in buttonsToRemove)
            {
                canvas.Children.Remove(button);
            }
        }



        private void nextPage(object sender, RoutedEventArgs e)
        {
            if (Database.SoundtrackRepo.Epic.Count() - 8 * (page + 1) > 0)
            {
                ++page;
                RemoveCircularButtons(myCanva);
                if (Database.SoundtrackRepo.Epic.Count() - 8 * page > 8 * page)
                {
                    CreateCircularButtons(myCanva, 8, 100);
                }
                else
                {
                    CreateCircularButtons(myCanva, Database.SoundtrackRepo.Epic.Count() - 8 * page, 100);
                }
            }
        }

        private void prevPage(object sender, RoutedEventArgs e)
        {
            if (page > 0)
            {
                --page;
                RemoveCircularButtons(myCanva);
                if (Database.SoundtrackRepo.Epic.Count() - 8 * page > 8 * page)
                {
                    CreateCircularButtons(myCanva, 8, 100);
                }
                else
                {
                    CreateCircularButtons(myCanva, Database.SoundtrackRepo.Epic.Count() - 8 * page, 100);
                }
            }
        }
    }
}
