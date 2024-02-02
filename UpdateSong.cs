using MusicLibrary.Obejcts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class UpdateSong : Form
    {
        DatabaseConnection databaseConnection;
        Song song;
        Form1 form1;
        public UpdateSong(DatabaseConnection dbConnection, Song selectedSong, Form1 form)
        {
            InitializeComponent();
            this.databaseConnection = dbConnection;
            this.song = selectedSong;
            this.form1 = form;
            LoadArtists();
            LoadGenres();
            insertSong(selectedSong);
        }

        private void LoadGenres()
        {
            List<Genre> genres = databaseConnection.GetGenres();
            listBox2.Items.Clear();
            foreach (Genre genre in genres)
            {
                listBox2.Items.Add(genre);
            }
        }

        private void LoadArtists()
        {
            List<Artist> artists = databaseConnection.GetArtists();
            listBox1.Items.Clear();
            foreach (Artist artist in artists)
            {
                listBox1.Items.Add(artist);
            }
        }

        private void UpdateSong_Load(object sender, EventArgs e)
        {

        }

        private void updateSongButton_Click(object sender, EventArgs e)
        {
            string updatedSongName = songTextBox.Text;
            int updatedRanking = (int)rankNumeric.Value;
            string updatedArtistName = artistIdTextBox.Text;
            string updatedGenreName = GenreIdTextBox.Text;
            int updatedPlaytime = int.Parse(playtimeTextBox.Text);
            string updatedSpotifyLink = spotifyTextBox.Text;
            int songId = song.SongId;

            if (int.TryParse(playtimeTextBox.Text, out updatedPlaytime))
            {
                bool success = databaseConnection.updateSong(
                    updatedRanking,
                    updatedSongName,
                    updatedArtistName,
                    updatedPlaytime,
                    updatedGenreName,
                    spotifyTextBox.Text,
                    song.SongId
                );

                if (success)
                {
                    MessageBox.Show("Song updated successfully!");
                    this.Close();
                    form1.refreshListBox(); // Call the method to refresh the listbox in Form1
                }
                else
                {
                    MessageBox.Show("Error updating the song.");
                }
            }
            else
            {
                MessageBox.Show("Error! Please try again");
            }
        }

        public void InsertSong(Song selectedSong)
        {
            songTextBox.Text = selectedSong.SongName;
            rankNumeric.Value = selectedSong.Ranking;
            artistIdTextBox.Text = selectedSong.ArtistName;
            GenreIdTextBox.Text = selectedSong.GenreName;
            playtimeTextBox.Text = selectedSong.Playtime.ToString();
            spotifyTextBox.Text = selectedSong.SpotifyLink;
        }
    


        public void insertSong(Song selectedSong)
        {
            songTextBox.Text = selectedSong.SongName.ToString();
            rankNumeric.Value = selectedSong.Ranking;
            artistIdTextBox.Text = selectedSong.ArtistName.ToString();
            GenreIdTextBox.Text = selectedSong.GenreName.ToString();
            playtimeTextBox.Text = selectedSong.Playtime.ToString();
            spotifyTextBox.Text = selectedSong.SpotifyLink.ToString();
        }

    }
}
