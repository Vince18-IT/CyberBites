using System;
using System.Data.SQLite;
using System.IO;

namespace CyberBites
{
    public static class DatabaseHelper
    {
        // This will create the database file right in your Debug folder
        // This ensures the database is always looked for in the folder where the .exe is located
        private static string dbFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CyberBitesDB.sqlite");

        // This is the "Key" that allows your forms to open the database
        public static string ConnectionString = $"Data Source={dbFileName};Version=3;";

        // We run this exactly once when the app starts
        public static void InitializeDatabase()
        {
            // If the database file doesn't exist yet, create it!
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }

            // Always run this to make sure the tables exist
            CreateTables();
        }

        private static void CreateTables()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // Here is the Schema for your Users table (Including the ProfilePicture BLOB!)
                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        Username TEXT UNIQUE NOT NULL,
                        Password TEXT NOT NULL,
                        SeatNumber TEXT,
                        WalletBalance DECIMAL(10, 2) DEFAULT 0.00,
                        ProfilePicture BLOB
                    );";

                using (SQLiteCommand cmd = new SQLiteCommand(createUsersTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}