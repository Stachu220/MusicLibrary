using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MusicLibrary.Database
{
    internal class DatabaseInit
    {
        private const string ConnectionString = "Data Source=MusicLibrary.db;Version=3;";
        public static void InitDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var createCategoryTable = @"CREATE TABLE IF NOT EXISTS Category (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT
                )";

                using (var command = new SQLiteCommand(createCategoryTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                var createSoundtrackTable = @"CREATE TABLE IF NOT EXISTS Soundtrack (
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Filename TEXT NOT NULL,
                DisplayName TEXT NOT NULL,
                CategoryID INTEGER NOT NULL,
                Duration TEXT,
                DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP,
                Tags TEXT,
                FileFormat TEXT,
                FOREIGN KEY(CategoryID) REFERENCES Category(ID)
                );";

                using (var command = new SQLiteCommand(createSoundtrackTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
