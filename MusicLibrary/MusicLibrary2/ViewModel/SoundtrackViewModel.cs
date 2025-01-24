using MusicLibrary2.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MusicLibrary.ViewModel
{
    public class SoundtrackViewModel
    {
        public ObservableCollection<Soundtrack> Soundtracks { get; set; }
        private SoundtrackRepo _repository;

        public SoundtrackViewModel()
        {
            _repository = new SoundtrackRepo();
            Soundtracks = new ObservableCollection<Soundtrack>(_repository.GetAllSoundtracks());

            AddSoundtrackCommand = new RelayCommand(AddSoundtrack);
        }

        public ICommand AddSoundtrackCommand { get; }

        private void AddSoundtrack()
        {
            var newSoundtrack = new Soundtrack
            {
                Filename = "newSoundtrack.mp3",
                DisplayName = "New Soundtrack",
                CategoryID = 1,
                Duration = "3:00",
                Tags = "TestTag",
                FileFormat = ".mp3"
            };
            _repository.AddSoundtrack(newSoundtrack);
            Soundtracks.Add(newSoundtrack);
        }

        private void RemoveSoundtrack(Soundtrack soundtrack)
        {
            // Remove the selected soundtrack
        }
    }
}
    