using MusicLibrary.Obejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Users
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public List<PlayList> PlayList { get; set; } = new List<PlayList>();

        public User(string name, string password)
        {
            Name = name;
            Password = password;

            CreatePlaylist("My Playlist");
        }

        public void CreatePlaylist(string playlistName)
        {
            PlayList newPlaylist = new PlayList(PlayList.Count + 1, playlistName);
            PlayList.Add(newPlaylist);
            //PlayList playList = new PlayList(playlistName);
            //PlayList.Add(playList);
        }
    }
}
