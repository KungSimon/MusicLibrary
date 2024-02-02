using MusicLibrary.Obejcts;
using MusicLibrary.Users;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MusicLibrary
{
    public partial class Form1 : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        private UserManager userManager;
        Dictionary<int, Song> songs = new Dictionary<int, Song>();
        List<Song> songList = new List<Song>();

        public Form1()
        {
            InitializeComponent();
            //dbConnection = new DatabaseConnection();
            //songs = db.GetSongsAndArtist();
            /*songList = songs.Values.ToList();
            foreach (Song shop in songList)
            {
                topListBox.Items.Add(shop.ToString());
            }

            db.GetGenre(songs);*/
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            userManager = new UserManager();
            userManager.LoadUsersFromJson("users.json");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTopSongs();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            userManager.SaveUsersToJson("users.json");
        }

        private void LoadTopSongs()
        {

            //db.GetSongsAndArtist(topListBox, "SELECT * FROM songs_full_info");
            topListBox.Items.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT * FROM songs_full_info";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int songId = Convert.ToInt32(reader["song_id"]);
                            int ranking = Convert.ToInt32(reader["ranking"]);
                            string songName = reader["song_name"].ToString();
                            string artistName = reader["artist_name"].ToString();
                            int playtime = Convert.ToInt32(reader["playtime"]);
                            string genreName = reader["genre_name"].ToString();
                            string spotifyLink = reader["spotify_link"].ToString(); // Get the Spotify link

                            // Create a Song object
                            Song song = new Song(songId, ranking, songName, artistName, playtime, genreName, spotifyLink);

                            // Add the Song object to the ListBox
                            topListBox.Items.Add(song);
                        }
                        conn.Close();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchListBox.SelectedIndex != -1)
            {
                // Get the selected song from the ListBox
                Song selectedSong = (Song)searchListBox.SelectedItem;

                // Display the Spotify link in the spotifyLinkLabel
                linkLabel.Text = selectedSong.SpotifyLink;
            }
        }

        private void topListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (topListBox.SelectedIndex != -1)
            {
                // Get the selected song from the ListBox
                Song selectedSong = (Song)topListBox.SelectedItem;

                // Display the Spotify link in the spotifyLinkLabel
                spotifyLinkLabel1.Text = selectedSong.SpotifyLink;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void spotifyLink_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                userManager.AddUser(userName, password); // Try to add the user (will throw exception if username exists)
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            User foundUser = userManager.RegisteredUsers.FirstOrDefault(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase) && u.Password == password);

            if (foundUser != null)
            {
                userManager.CurrentUser = foundUser;
                MessageBox.Show("Login successful!");
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                usernameLabel.Visible = false;
                usernameTextBox.Visible = false;
                passwordLabel.Visible = false;
                passwordTextBox.Visible = false;
                loginButton.Visible = false;
                registerButton.Visible = false;
                logoutButton.Visible = true;
                uppdateInfoButton.Visible = true;
                deleteButton.Visible = true;
                addNewSongButton.Visible = true;
                playListLabel.Visible = true;
                playListBox.Visible = true;
                PlayListListenLabel.Visible = true;
                linkLabel11.Visible = true;
                addToPlayListButton.Visible = true;
                songsInPlayListBox.Visible = true;
                songsInPlaylistLabel.Visible = true;
                LoadPlaylists();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                passwordTextBox.Text = "";
            }
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = linkLabel.Text;

            // Open the URL in the default web browser
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void spotifyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Get the URL from the LinkLabel's Text
            string url = spotifyLinkLabel1.Text;

            // Open the URL in the default web browser
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser registerForm = new RegisterUser(userManager);
            registerForm.ShowDialog();
        }

        private void addNewSongButton_Click(object sender, EventArgs e)
        {
            AddNewSong addNewSong = new AddNewSong(topListBox, db, this);
            addNewSong.Show();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            usernameLabel.Visible = true;
            usernameTextBox.Visible = true;
            passwordLabel.Visible = true;
            passwordTextBox.Visible = true;
            loginButton.Visible = true;
            registerButton.Visible = true;
            logoutButton.Visible = false;
            uppdateInfoButton.Visible = false;
            deleteButton.Visible = false;
            addNewSongButton.Visible = false;
            playListLabel.Visible = false;
            playListBox.Visible = false;
            PlayListListenLabel.Visible = false;
            linkLabel11.Visible = false;
            addToPlayListButton.Visible = false;
            songsInPlayListBox.Visible = false;
            songsInPlaylistLabel.Visible = false;
        }

        private void uppdateInfoButton_Click(object sender, EventArgs e)
        {
            if (topListBox.SelectedIndex != -1)
            {
                // Get the selected song from the ListBox
                Song selectedSong = (Song)topListBox.SelectedItem;
                UpdateSong updateSong = new UpdateSong(db, selectedSong, this);
                updateSong.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (topListBox.SelectedIndex != -1)
            {
                // Get the selected song from the ListBox
                Song selectedSong = (Song)topListBox.SelectedItem;

                // Confirm with the user
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the song:\n\n{selectedSong}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Call the method in DatabaseConnection to delete the song
                    if (db.DeleteSong(selectedSong))
                    {
                        // If deletion is successful, refresh the topListBox
                        LoadTopSongs();
                        MessageBox.Show("Song deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting the song.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a song to delete.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                List<Song> searchResults = db.SearchSongsAndArtists(searchTerm);

                // Clear the previous search results
                searchListBox.Items.Clear();

                // Populate the searchListBox with the search results
                foreach (Song resultSong in searchResults)
                {
                    searchListBox.Items.Add(resultSong);
                }
            }
        }

        public void addSong(Song song)
        {
            songList.Add(song);
            LoadTopSongs();
            topListBox.Refresh();

        }

        private void addToPlayListButton_Click(object sender, EventArgs e)
        {
            if (topListBox.SelectedIndex != -1)
            {
                Song selectedSong = (Song)topListBox.SelectedItem;

                User currentUser = userManager.CurrentUser;

                if (currentUser != null && currentUser.PlayList.Count > 0)
                {
                    // Fetch playlists from the database
                    List<PlayList> playlists = db.GetPlaylists();

                    // Show the SelectPlaylist form with fetched playlists
                    SelectPlaylist selectPlaylistForm = new SelectPlaylist(playlists);
                    selectPlaylistForm.ShowDialog();

                    // Check if a playlist was selected
                    if (selectPlaylistForm.SelectedPlaylist != null)
                    {
                        // Add the selected song to the chosen playlist
                        selectPlaylistForm.SelectedPlaylist.AddSong(selectedSong);

                        // Add the song to the songs_in_playlist table
                        db.AddSongToPlaylist(selectPlaylistForm.SelectedPlaylist.PlaylistId, selectedSong.SongId);

                        // Optionally, update your UI or show a confirmation message
                        MessageBox.Show($"{selectedSong.SongName} added to playlist '{selectPlaylistForm.SelectedPlaylist.Name}' successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("User or playlist not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a song to add to the playlist.");
            }
        }
        /*if (topListBox.SelectedIndex != -1)
        {
            Song selectedSong = (Song)topListBox.SelectedItem;

            User currentUser = userManager.CurrentUser;

            if (currentUser != null && currentUser.PlayList.Count > 0)
            {
                currentUser.PlayList[0].AddSong(selectedSong);

                playListBox.Items.Add(selectedSong);

                MessageBox.Show("Song added to playlist successfully!");
            }
            else
            {
                MessageBox.Show("User or playlist not found.");
            }
        }
        else
        {
            MessageBox.Show("Please select a song to add to the playlist.");
        }*/


        public void refreshListBox()
        {
            LoadTopSongs();
            topListBox.Refresh();
        }

        private void LoadPlaylists()
        {
            playListBox.Items.Clear();

            List<PlayList> playlists = db.GetPlaylists();

            // Display playlists in the ListBox
            foreach (PlayList playlist in playlists)
            {
                playListBox.Items.Add($"{playlist.PlaylistId}: {playlist.Name}");
            }
        }

        private void songsInPlayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (songsInPlayListBox.SelectedIndex != -1)
            {
                // Get the selected item from the list
                object selectedItem = songsInPlayListBox.SelectedItem;

                // Check if the selected item is a string
                if (selectedItem is string)
                {
                    // Extract the song ID from the string
                    string selectedString = (string)selectedItem;

                    // Try to parse the song ID
                    if (int.TryParse(selectedString.Split(':')[0], out int songId))
                    {
                        // Fetch the corresponding song from the database
                        Song selectedSong = db.GetSongById(songId);

                        if (selectedSong != null)
                        {
                            // Display the Spotify link in the spotifyLinkLabel
                            linkLabel11.Text = selectedSong.SpotifyLink;
                        }
                    }
                }
            }
        }

        private void playListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                songsInPlayListBox.Items.Clear();

                if (playListBox.SelectedIndex != -1)
                {
                    int selectedIndex = playListBox.SelectedIndex;

                    // Fetch playlists from the database
                    List<PlayList> playlists = db.GetPlaylists();

                    if (selectedIndex >= 0 && selectedIndex < playlists.Count)
                    {
                        PlayList selectedPlaylist = playlists[selectedIndex];

                        // Fetch songs in the selected playlist from the database
                        List<Song> songsInPlaylist = db.GetSongsInPlaylist(selectedPlaylist.PlaylistId);

                        if (songsInPlaylist != null && songsInPlaylist.Count > 0)
                        {
                            foreach (Song song in songsInPlaylist)
                            {
                                songsInPlayListBox.Items.Add($"{song.SongId}: {song.SongName}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selected playlist does not contain any songs.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid selected index or playlist not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = linkLabel11.Text;

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}