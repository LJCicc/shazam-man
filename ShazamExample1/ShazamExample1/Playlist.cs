using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Playlist
    {
        public List<Song> SongList;
        public List<Release> ReleaseList;
        public List<Activity> ActivityList;
        public List<Artist> ArtistList;
        public Playlist()
        {
            Console.WriteLine("Playlist started.");
            ReleaseList = new List<Release>();
        }
    }
}
