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
    public partial class SelectPlaylist : Form
    {
        // Property to hold the selected playlist
        public PlayList SelectedPlaylist { get; private set; }

        // List of available playlists
        private List<PlayList> playlists;
        public SelectPlaylist(List<PlayList> playlists)
        {
            InitializeComponent();
            this.playlists = playlists;
            LoadPlaylists();
        }

        private void LoadPlaylists()
        {
            // Display playlists in the ListBox
            foreach (PlayList playlist in playlists)
            {
                playListBox.Items.Add($"{playlist.PlaylistId}: {playlist.Name}");
            }
        }

        private void SelectPlaylist_Load(object sender, EventArgs e)
        {

        }

        private void playListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToPLaylistButton_Click(object sender, EventArgs e)
        {
            {
                if (playListBox.SelectedIndex != -1)
                {
                    // Get the selected playlist index
                    int selectedIndex = playListBox.SelectedIndex;

                    // Get the corresponding playlist
                    SelectedPlaylist = playlists[selectedIndex];

                    // Close the form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select a playlist.");
                }
            }
        }
    }
}
