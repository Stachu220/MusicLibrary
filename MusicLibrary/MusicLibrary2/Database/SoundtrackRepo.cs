using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary2.Database
{
    internal class SoundtrackRepo
    {
        private const string Connection = "Data Source=musiclibrary.db;";
        public static List<Soundtrack> Folk = new List<Soundtrack>();
        public static List<Soundtrack> Battle = new List<Soundtrack>();
        public static List<Soundtrack> Tavern = new List<Soundtrack>();
        public static List<Soundtrack> Forest = new List<Soundtrack>();
        public static List<Soundtrack> Cavern = new List<Soundtrack>();
        public static List<Soundtrack> Night = new List<Soundtrack>();
        public static List<Soundtrack> Epic = new List<Soundtrack>();

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
                            Description = reader.GetString(3),
                            CategoryID = reader.GetInt32(4),
                            Duration = reader.GetString(5),
                            Tags = reader.GetString(6)
                        });
                        switch(reader.GetInt32(4))
                        { 
                            case 1:
                                Folk.Add(soundtracks[soundtracks.Count - 1]);
                                break;
                            case 2:
                                Battle.Add(soundtracks[soundtracks.Count - 1]);
                                break;
                            case 3:
                                Tavern.Add(soundtracks[soundtracks.Count - 1]);
                                break;
                            case 4:
                                Forest.Add(soundtracks[soundtracks.Count - 1]);
                                break;
                            case 5:
                                Cavern.Add(soundtracks[soundtracks.Count - 1]);
                                break;
                            case 6:
                                Night.Add(soundtracks[soundtracks.Count - 1]);
                                break;
                            case 7:
                                Epic.Add(soundtracks[soundtracks.Count - 1]);
                                break;
                        }

                    }
                }
            }
            return soundtracks;
        }

        public static void AddSoundtrack(Soundtrack soundtrack)
        {
            using (var connection = new SQLiteConnection(Connection))
            {
                connection.Open();
                var query = "INSERT INTO Soundtrack (Filename, DisplayName, Description, CategoryID, Duration, Tags) VALUES (@Filename, @DisplayName, @Description,@CategoryID, @Duration, @Tags)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Filename", soundtrack.Filename);
                    command.Parameters.AddWithValue("@DisplayName", soundtrack.DisplayName);
                    command.Parameters.AddWithValue("@Description", soundtrack.Description);
                    command.Parameters.AddWithValue("@CategoryID", soundtrack.CategoryID);
                    command.Parameters.AddWithValue("@Duration", soundtrack.Duration);
                    command.Parameters.AddWithValue("@Tags", soundtrack.Tags);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetCategoryID(string category)
        {
            using (var connection = new SQLiteConnection(Connection))
            {
                connection.Open();
                var query = "SELECT ID FROM Category WHERE Name = @Name";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", category);
                    int ID = Convert.ToInt32(command.ExecuteScalar());
                    return ID;
                }
            }
        }
    }
}
