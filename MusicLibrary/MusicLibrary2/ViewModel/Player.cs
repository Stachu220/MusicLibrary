using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary2.ViewModel
{
    class Player
    {
        private static readonly Lazy<Player> _instance = new Lazy<Player>(() => new Player());
        private static LibVLC _libVLC;
        private static MediaPlayer _mediaPlayer;
        public static int vol = 10;

        private static string _tempTitle;
        public static string TempTitle
        {
            get => _tempTitle;
            set => _tempTitle = value ?? throw new ArgumentNullException(nameof(value));
        }

        private static bool _isLoop;
        public static bool IsLoop
        {
            get => _isLoop;
            set => _isLoop = value;
        }
        public static Player Instance => _instance.Value;
        private string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

        public Player()
        {
            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            _mediaPlayer.EndReached += async (sender, args) =>
            {
                if (_isLoop)
                {
                    await Task.Delay(10); // Add a small delay
                    Play();
                }
            };
        }

        public void Play()
        {
            try
            {
            // Play the selected song
            string title = System.IO.Path.Combine(path, "Soundtracks", TempTitle);
            var media = new Media(_libVLC, title);
            _mediaPlayer.Media = media;
            _mediaPlayer.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Stop()
        {
            _mediaPlayer.Pause();
        }

        public void SetVolume(int volume)
        {
            _mediaPlayer.Volume = volume;
            vol = volume;
        }

        public bool IsPlaying => _mediaPlayer.IsPlaying;
    }
}
