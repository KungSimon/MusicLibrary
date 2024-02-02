using MusicLibrary.Obejcts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace MusicLibrary
{
    public class DatabaseConnection
    {
        string server = "localhost";
        string database = "musiclibrary";
        string username = "_admin";
        string password = "admin";

        public string connectionString = "";
        MySqlConnection connection;

        public DatabaseConnection()
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        public List<Artist> GetArtists()
        {
            List<Artist> artists = new List<Artist>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT * FROM artist";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int artistId = (int)reader["artist_id"];
                            string artistName = (string)reader["artist_name"];

                            Artist artist = new Artist(artistId, artistName);
                            artists.Add(artist);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return artists;
        }


        public void AddArtist(string artistName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the artist already exists
                    if (!ArtistExists(artistName, conn))
                    {
                        string insertQuery = "INSERT INTO artist (artist_name) VALUES (@artistName)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@artistName", artistName);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Artist already exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private bool ArtistExists(string artistName, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM artist WHERE artist_name = @artistName";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@artistName", artistName);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }



        public List<Genre> GetGenres()
        {
            List<Genre> genres = new List<Genre>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT * FROM genre";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int genreId = (int)reader["genre_id"];
                            string genreName = (string)reader["genre_name"];

                            Genre genre = new Genre(genreId, genreName);
                            genres.Add(genre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return genres;
        }


        public void AddGenre(string genreName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    if (!GenreExists(genreName, conn))
                    {
                        string insertQuery = "INSERT INTO genre (genre_name) VALUES (@genreName)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@genreName", genreName);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Genre already exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private bool GenreExists(string genreName, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM genre WHERE genre_name = @genreName";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@genreName", genreName);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public List<Song> SearchSongsAndArtists(string searchTerm)
        {
            List<Song> searchResults = new List<Song>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
                {
                    conn.Open();

                    // Use the stored procedure
                    using (MySqlCommand command = new MySqlCommand("SearchSongsByTerm", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_search_term", searchTerm);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int songId = (int)reader["song_id"];
                                int ranking = (int)reader["ranking"];
                                string songName = (string)reader["song_name"];
                                string artistName = (string)reader["artist_name"];
                                int playtime = (int)reader["playtime"];
                                string genreName = (string)reader["genre_name"];
                                string spotifyLink = (string)reader["spotify_link"];

                                Song song = new Song(songId, ranking, songName, artistName, playtime, genreName, spotifyLink);
                                searchResults.Add(song);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return searchResults;
        }
        /*List<Song> searchResults = new List<Song>();
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();

                string sqlQuery = "SELECT * FROM songs_full_info WHERE song_name LIKE @searchTerm OR artist_name LIKE @searchTerm OR genre_name LIKE @searchTerm OR song_id LIKE @searchTerm";

                using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int songId = (int)reader["song_id"];
                            int ranking = (int)reader["ranking"];
                            string songName = (string)reader["song_name"];
                            string artistName = (string)reader["artist_name"];
                            int playtime = (int)reader["playtime"];
                            string genreName = (string)reader["genre_name"];
                            string spotifyLink = (string)reader["spotify_link"];

                            Song song = new Song(songId, ranking, songName, artistName, playtime, genreName, spotifyLink);

                            searchResults.Add(song);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }

        return searchResults;
    }*/

        public Song AddNewSong(string songName, string artistId, int playtime, string genreId, string spotifyLink)
        {
            try
            {
                connection.Open();

                if (!SongExists(songName, connection))
                {

                    string getMaxRankingQuery = "SELECT MAX(ranking) FROM song";
                    MySqlCommand getMaxRankingCommand = new MySqlCommand(getMaxRankingQuery, connection);
                    object result = getMaxRankingCommand.ExecuteScalar();
                    int highestRanking = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);

                    int newRanking = highestRanking + 1;

                    string insertQuery = "INSERT INTO song (ranking, song_name, playtime, artist_id, genre_id, spotify_link) " +
                                         "VALUES (@ranking, @songName, @playtime, @artistId, @genreId, @spotifyLink); " +
                                         "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ranking", newRanking);
                        insertCommand.Parameters.AddWithValue("@songName", songName);
                        insertCommand.Parameters.AddWithValue("@playtime", playtime);
                        insertCommand.Parameters.AddWithValue("@artistId", artistId);
                        insertCommand.Parameters.AddWithValue("@genreId", genreId);
                        insertCommand.Parameters.AddWithValue("@spotifyLink", spotifyLink);

                        int newSongId = Convert.ToInt32(insertCommand.ExecuteScalar());

                        connection.Close();

                        Song newSong = new Song(newSongId, newRanking, songName, artistId, playtime, genreId, spotifyLink);
                        return newSong;
                    }
                }
                else
                {
                    MessageBox.Show("Song already exists!");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private bool SongExists(string songName, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM song WHERE song_name = @songName";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@songName", songName);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }


        public bool DeleteSong(Song song)
        {
            try
            {
                connection.Open();

                string deleteQuery = "DELETE FROM song WHERE ranking = @ranking";

                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@ranking", song.Ranking);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool updateSong(int rank, string songName, string artistId, int playtime, string genreId, string spotifyLink, int songId)
        {
            try
            {
                connection.Open();

                if (!SongExists(songName, connection) || GetSongById(songId)?.SongName == songName)
                {

                    string updateQuery = "UPDATE song SET ranking = @ranking, song_name = @songName, artist_id = @artistId, playtime = @playtime, genre_id = @genreId, spotify_link = @spotifyLink WHERE song_id = @songId";

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@ranking", rank);
                        updateCommand.Parameters.AddWithValue("@songName", songName);
                        updateCommand.Parameters.AddWithValue("@artistId", artistId);
                        updateCommand.Parameters.AddWithValue("@playtime", playtime);
                        updateCommand.Parameters.AddWithValue("@genreId", genreId);
                        updateCommand.Parameters.AddWithValue("@spotifyLink", spotifyLink);
                        updateCommand.Parameters.AddWithValue("@songId", songId);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                else
                {
                    MessageBox.Show("Song name already exists!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }


        public List<PlayList> GetPlaylists()
        {
            List<PlayList> playlists = new List<PlayList>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT * FROM playlist";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playlistId = Convert.ToInt32(reader["playlist_id"]);
                            string playlistName = reader["playlist_name"].ToString();

                            PlayList playlist = new PlayList(playlistId, playlistName);
                            playlists.Add(playlist);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return playlists;
        }


        public bool AddSongToPlaylist(int playlistId, int songId)
        {

            try
            {
                connection.Open();

                // Checks if the song is already in the playlist
                if (!SongExistsInPlaylist(playlistId, songId, connection))
                {
                    string insertQuery = "INSERT INTO songs_in_playlist (playlist_id, song_id) VALUES (@playlistId, @songId)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@playlistId", playlistId);
                        insertCommand.Parameters.AddWithValue("@songId", songId);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                else
                {
                    MessageBox.Show("Song already exists in the playlist.");
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) 
                {
                    // Handle the duplicate entry error as needed
                    MessageBox.Show("Error: This song is already in the playlist.");
                    return false;
                }
                else
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
            /*try
            {
                connection.Open();

                // Check if the song is already in the playlist
                if (!SongExistsInPlaylist(playlistId, songId, connection))
                {
                    string insertQuery = "INSERT INTO songs_in_playlist (playlist_id, song_id) VALUES (@playlistId, @songId)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@playlistId", playlistId);
                        insertCommand.Parameters.AddWithValue("@songId", songId);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                else
                {
                    MessageBox.Show("Song already exists in the playlist.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }*/

            /*try
            {
                connection.Open();

                string insertQuery = "INSERT INTO songs_in_playlist (playlist_id, song_id) VALUES (@playlistId, @songId)";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@playlistId", playlistId);
                    insertCommand.Parameters.AddWithValue("@songId", songId);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }*/


        }

        private bool SongExistsInPlaylist(int playlistId, int songId, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM songs_in_playlist WHERE playlist_id = @playlistId AND song_id = @songId";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@playlistId", playlistId);
                command.Parameters.AddWithValue("@songId", songId);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }


        public List<Song> GetSongsInPlaylist(int playlistId)
        {
            List<Song> songsInPlaylist = new List<Song>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT s.song_id, s.song_name, s.spotify_link " +
                                      "FROM song s " +
                                      "JOIN songs_in_playlist sp ON s.song_id = sp.song_id " +
                                      "WHERE sp.playlist_id = @playlistId";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@playlistId", playlistId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Populate Song object with data from the database
                                int songId = Convert.ToInt32(reader["song_id"]);
                                string songName = reader["song_name"].ToString();
                                string spotifyLink = reader["spotify_link"].ToString();

                                // Create a new Song object and add it to the list
                                Song song = new Song(songId, -1, songName, "", -1, "", spotifyLink);
                                songsInPlaylist.Add(song);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return songsInPlaylist;
        }

        /*List<Song> songsInPlaylist = new List<Song>();
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sqlQuery = "SELECT s.* FROM song s " +
                                  "JOIN songs_in_playlist sp ON s.song_id = sp.song_id " +
                                  "WHERE sp.playlist_id = @playlistId";

                using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@playlistId", playlistId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Populate Song object with data from the database
                            int songId = Convert.ToInt32(reader["song_id"]);
                            int ranking = Convert.ToInt32(reader["ranking"]);
                            string songName = reader["song_name"].ToString();
                            string artistName = reader["artist_name"].ToString();
                            int playtime = Convert.ToInt32(reader["playtime"]);
                            string genreName = reader["genre_name"].ToString();
                            string spotifyLink = reader["spotify_link"].ToString();

                            Song song = new Song(songId, ranking, songName, artistName, playtime, genreName, spotifyLink);
                            songsInPlaylist.Add(song);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }

        return songsInPlaylist;
    }*/


        public Song GetSongById(int songId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT * FROM songs_full_info WHERE song_id = @songId";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@songId", songId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int ranking = Convert.ToInt32(reader["ranking"]);
                                string songName = reader["song_name"].ToString();
                                string artistName = reader["artist_name"].ToString();
                                int playtime = Convert.ToInt32(reader["playtime"]);
                                string genreName = reader["genre_name"].ToString();
                                string spotifyLink = reader["spotify_link"].ToString();

                                return new Song(songId, ranking, songName, artistName, playtime, genreName, spotifyLink);
                            }
                            else
                            {
                                MessageBox.Show("Song not found.");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }

    }
}
