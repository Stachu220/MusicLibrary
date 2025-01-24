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
using System.Windows.Shapes;

namespace MusicLibrary2
{
    public partial class FolkCategory : UserControl
    {

        public FolkCategory()
        {
            InitializeComponent();


            CreateCircularButtons(myCanva, 8, 100);
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

                // Calculate button width based on the angle (wider on the outside, thinner on the inside)
                double buttonWidth = 50 + (radius - 50) * Math.Abs(Math.Cos(angle)); // This adjusts the width dynamically
                double buttonHeight = 50 + (radius - 50) * Math.Abs(Math.Sin(angle)); // You can adjust height as well

                Button button = new Button
                {
                    Content = (i + 1).ToString(),
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Style = (Style)FindResource("SoundtrackButton")
                };

                Canvas.SetLeft(button, x - buttonWidth / 2); // Adjust for button width
                Canvas.SetTop(button, y - buttonHeight / 2); // Adjust for button height

                canvas.Children.Add(button);
            }
        }

        private void goToAdd(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new AddSong(this));
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

        private void goToEpic(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateTo(new EpicCategory());
        }
    }
}
