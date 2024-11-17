using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Database
{
    internal class SoundtrackRepo
    {
        private const string Connection = "Data Source=MusicLibrary.db;Version=3;";

        public List<Soundtrack> GetAllSoundtracks()
        {
            var soundtracks = new List<Soundtrack>();
            
            using (var connection = new SQLiteConnection(Connection))
            {
                connection.Open();
                var query = "SELECT * FROM Soundtrack";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        soundtracks.Add(new Soundtrack
                        {
                            ID = reader.GetInt32(0),
                            Filename = reader.GetString(1),
                            DisplayName = reader.GetString(2),
                            CategoryID = reader.GetInt32(3),
                            Duration = reader.GetString(4),
                            DateAdded = reader.GetDateTime(5),
                            Tags = reader.GetString(6),
                            FileFormat = reader.GetString(7)
                        });
                    }
                }
            }
            return soundtracks;
        }

        public void AddSoundtrack(Soundtrack soundtrack)
        {
            using (var connection = new SQLiteConnection(Connection))
            {
                connection.Open();
                var query = "INSERT INTO Soundtrack (Filename, DisplayName, CategoryID, Duration, Tags, FileFormat) VALUES (@Filename, @DisplayName, @CategoryID, @Duration, @Tags, @FileFormat)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Filename", soundtrack.Filename);
                    command.Parameters.AddWithValue("@DisplayName", soundtrack.DisplayName);
                    command.Parameters.AddWithValue("@CategoryID", soundtrack.CategoryID);
                    command.Parameters.AddWithValue("@Duration", soundtrack.Duration);
                    command.Parameters.AddWithValue("@Tags", soundtrack.Tags);
                    command.Parameters.AddWithValue("@FileFormat", soundtrack.FileFormat);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
