using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace MusicLibrary2.Database
{
    internal class DatabaseInit
    {
        private const string ConnectionString = "Data Source=Musiclibrary.db; Version=3";
        public static void InitDatabase()
        {
            if (!File.Exists("Musiclibrary.db"))
            {
                SQLiteConnection.CreateFile("Musiclibrary.db");

                using var connection = new SQLiteConnection(ConnectionString);
                connection.Open();

                CreateTables(connection);

                FillCategories(connection);
            }
        }

        private static void CreateTables(SQLiteConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE Category (
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL
                );";
            command.ExecuteNonQuery();

            command.CommandText = @"
                CREATE TABLE Soundtrack (
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Filename TEXT NOT NULL,
                DisplayName TEXT NOT NULL,
                Description TEXT NOT NULL,
                CategoryID INTEGER NOT NULL,
                Duration TEXT NOT NULL,
                Tags TEXT NOT NULL,
                FOREIGN KEY(CategoryID) REFERENCES Category(ID)
                );";
            command.ExecuteNonQuery();

        }

        private static void FillCategories(SQLiteConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Category (Name) VALUES ('Folk');
                INSERT INTO Category (Name) VALUES ('Battle');
                INSERT INTO Category (Name) VALUES ('Tavern');
                INSERT INTO Category (Name) VALUES ('Forest');
                INSERT INTO Category (Name) VALUES ('Cavern');
                INSERT INTO Category (Name) VALUES ('Night');
                INSERT INTO Category (Name) VALUES ('Epic');
                ";
            command.ExecuteNonQuery();
        }
    }
}
