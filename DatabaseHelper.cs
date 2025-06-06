using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using static LAB12_ANALIZY_BIOINFORMATYCZNE.Form2;
using static LAB12_ANALIZY_BIOINFORMATYCZNE.Form4;

namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    internal static class DatabaseHelper
    {

        private static string DbFileName = @"C:\Users\kkami\Desktop\LAB12-ANALIZY BIOINFORMATYCZNE\baza.db";
        private static string ConnectionString => $"Data Source={DbFileName};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(DbFileName))
            {
                SQLiteConnection.CreateFile(DbFileName);
            }

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createSesjeTable = @"
                    CREATE TABLE IF NOT EXISTS Sesje (
                        IdSesji TEXT PRIMARY KEY,
                        Tytul TEXT NOT NULL,
                        DataUtworzenia TEXT NOT NULL
                    );";

                string createWpisyTable = @"
                    CREATE TABLE IF NOT EXISTS Wpisy (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        IdSesji TEXT NOT NULL,
                        DataDodania TEXT NOT NULL,
                        Opis TEXT,
                        SciezkaZalacznika TEXT,
                        FOREIGN KEY (IdSesji) REFERENCES Sesje(IdSesji) ON DELETE CASCADE
                    );";

                using (var cmd = new SQLiteCommand(createSesjeTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SQLiteCommand(createWpisyTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DodajSesje(Sesja sesja)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Sesje (IdSesji, Tytul, DataUtworzenia) VALUES (@id, @tytul, @data)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", sesja.IdSesji);
                    cmd.Parameters.AddWithValue("@tytul", sesja.Tytul);
                    cmd.Parameters.AddWithValue("@data", sesja.DataUtworzenia.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DodajWpis(string idSesji, Wpis wpis)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Wpisy (IdSesji, DataDodania, Opis, SciezkaZalacznika) VALUES (@idSesji, @data, @opis, @sciezka)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idSesji", idSesji);
                    cmd.Parameters.AddWithValue("@data", wpis.DataDodania.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@opis", wpis.Opis);
                    cmd.Parameters.AddWithValue("@sciezka", wpis.SciezkaZalacznika);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Sesja> PobierzSesje()
        {
            var sesje = new List<Sesja>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sesjeQuery = "SELECT * FROM Sesje";
                using (var cmdSesje = new SQLiteCommand(sesjeQuery, connection))
                using (var readerSesje = cmdSesje.ExecuteReader())
                {
                    while (readerSesje.Read())
                    {
                        sesje.Add(new Sesja
                        {
                            IdSesji = readerSesje["IdSesji"].ToString(),
                            Tytul = readerSesje["Tytul"].ToString(),
                            DataUtworzenia = DateTime.Parse(readerSesje["DataUtworzenia"].ToString()),
                            Wpisy = new List<Wpis>()
                        });
                    }
                }

                string wpisyQuery = "SELECT * FROM Wpisy";
                using (var cmdWpisy = new SQLiteCommand(wpisyQuery, connection))
                using (var readerWpisy = cmdWpisy.ExecuteReader())
                {
                    while (readerWpisy.Read())
                    {
                        var wpis = new Wpis
                        {
                            DataDodania = DateTime.Parse(readerWpisy["DataDodania"].ToString()),
                            Opis = readerWpisy["Opis"].ToString(),
                            SciezkaZalacznika = readerWpisy["SciezkaZalacznika"].ToString()
                        };

                        string idSesji = readerWpisy["IdSesji"].ToString();
                        var sesja = sesje.Find(s => s.IdSesji == idSesji);
                        if (sesja != null)
                        {
                            sesja.Wpisy.Add(wpis);
                        }
                    }
                }
            }

            return sesje;
        }
    }
}
