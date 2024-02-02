using MusicLibrary.Obejcts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class AddNewSong : Form
    {
        Form1 form;
        DatabaseConnection databaseConnection;
        private ListBox topListBox;

        public AddNewSong(ListBox topListBox, DatabaseConnection dbConnection, Form1 form)
        {
            InitializeComponent();
            this.databaseConnection = dbConnection;
            this.topListBox = topListBox;

            LoadArtists();
            LoadGenres();
            this.form = form;
        }

        public void addsongButton_Click(object sender, EventArgs e)
        {
            string songName = songTextBox.Text;
            string artistId = artistIdTextBox.Text;
            string genreId = GenreIdTextBox.Text;
            string spotifyLink = spotifyTextBox.Text;
            int playtime;

            if (int.TryParse(playtimeTextBox.Text, out playtime))
            {
                Song newSong = databaseConnection.AddNewSong(songName, artistId, playtime, genreId, spotifyLink);
                form.addSong(newSong);
                //databaseConnection.GetAll(topListBox, "SELECT * FROM songs_full_info");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error! Please try again");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void songTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void artistTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playtimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void spotifyTextBox_TextChanged(object sender, EventArgs e)
        {

        }




        private void rankNumericUpDown_ValueChanged(object sender, EventArgs e)
        {


        }

        private void GenreSelectedBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArtistsSelectedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addArtistButton_Click(object sender, EventArgs e)
        {
            string artistName = ArtistsSelectedTextBox.Text;

            // Check if the artist already exists
            List<Artist> artists = databaseConnection.GetArtists();
            if (artists.Any(artist => artist.Name.Equals(artistName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This artist already exists!");
                return;
            }

            databaseConnection.AddArtist(artistName);
            LoadArtists();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            string genreName = GenreSelectedBox1.Text;

            // Check if the genre already exists
            List<Genre> genres = databaseConnection.GetGenres();
            if (genres.Any(genre => genre.Name.Equals(genreName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This genre already exists.");
                return;
            }

            // Add the genre to the database
            databaseConnection.AddGenre(genreName);

            // Refresh the genre list
            LoadGenres();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void LoadArtists()
        {
            List<Artist> artists = databaseConnection.GetArtists();
            listBox1.Items.Clear();
            foreach (Artist artist in artists)
            {
                listBox1.Items.Add(artist);
            }
        }

        public void LoadGenres()
        {
            // Load genres into the listbox
            List<Genre> genres = databaseConnection.GetGenres();
            listBox2.Items.Clear();
            foreach (Genre genre in genres)
            {
                listBox2.Items.Add(genre);
            }
        }

        private void addArtistsOrGenresButton_Click(object sender, EventArgs e)
        {
            addArtistsOrGenresButton.Visible = false;
            artistLabel.Visible = true;
            genreLabel.Visible = true;
            ArtistsSelectedTextBox.Visible = true;
            GenreSelectedBox1.Visible = true;
            addGenreButton.Visible = true;
            addArtistButton.Visible = true;
        }

        private void artistIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenreIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
