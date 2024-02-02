using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Obejcts
{
    public class PlayList
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
        public PlayList(int playlistId, string name) 
        {
            PlaylistId = playlistId;
            Name = name;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }

        public override string ToString() 
        {
            return Name;
        }
    }
}
