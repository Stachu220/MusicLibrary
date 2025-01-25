using MusicLibrary2.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MusicLibrary2.ViewModel
{
    public class SoundtrackViewModel
    {
        //public ObservableCollection<Soundtrack> Soundtracks { get; set; }
        //private SoundtrackRepo _repository;
        //private string _filename;
        //private string _dispName;
        //private string _description;
        //private int _catID;
        //private string _dur;
        //private string _tags;

        //public SoundtrackViewModel()
        //{
        //    _repository = new SoundtrackRepo();
        //    Soundtracks = new ObservableCollection<Soundtrack>(_repository.GetAllSoundtracks());

        //    //AddSoundtrackCommand = new RelayCommand(AddSoundtrack(_filename, _dispName, _description, _catID, _dur, _tags));
        //}

        ////public ICommand AddSoundtrackCommand { get; }

        //private void AddSoundtrack(string filename, string dispName, string description, int catID, string dur, string tags)
        //{
        //    var newSoundtrack = new Soundtrack
        //    {
        //        Filename = filename,
        //        DisplayName = dispName,
        //        Description = description,
        //        CategoryID = catID,
        //        Duration = dur,
        //        Tags = tags,
        //    };
        //    _repository.AddSoundtrack(newSoundtrack);
        //    Soundtracks.Add(newSoundtrack);
        //}

        //private void RemoveSoundtrack(Soundtrack soundtrack)
        //{
        //    // Remove the selected soundtrack
        //}
    }
}
    