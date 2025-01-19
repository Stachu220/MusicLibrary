using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Database.DatabaseInit.InitDatabase();
            DataContext = new ViewModel.SoundtrackViewModel();
            CreateCircularButtons(myCanva, 8, 100);

            // This code should be in the constructor or method after InitializeComponent()
            Uri imageUri = new Uri("Images/play.png", UriKind.Relative); // Ensure the path is correct

            // Set the image source
            playPauseButton.Source = new BitmapImage(imageUri);
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

    }
}