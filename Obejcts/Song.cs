using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Obejcts
{
    public class Song
    {
        public int SongId { get; set; }
        public int Ranking { get; set; }
        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public string GenreName { get; set; }
        public int Playtime { get; set; }
        public string SpotifyLink { get; set; }


        public List<Artist> Artist { get; set; } = new List<Artist>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<PlayList> Playlist { get; set; } = new List<PlayList>();

        public Song(int songId, int ranking, string songName, string artistName, int playtime, string genreName, string spotifyLink)
        {
            SongId = songId;
            Ranking = ranking;
            SongName = songName;
            ArtistName = artistName;
            Playtime = playtime;
            GenreName = genreName;
            SpotifyLink = spotifyLink;
        }

        public override string ToString()
        {
            return $"{Ranking}. {SongName} - {ArtistName} ({Playtime} seconds) - {GenreName}";

            //return Ranking + "\t" + SongName + "\t" + ArtistName + "\t" + GenreName;
        }
    }
}

