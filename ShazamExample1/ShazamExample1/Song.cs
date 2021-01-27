using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Song
    {
        private string _songTitle;
        private Artist Artist;
        private float duration;

        public string SongTitle { get => _songTitle; set => _songTitle = value; }
        public Artist Artist1 { get => Artist; set => Artist = value; }
        public float Duration { get => duration; set => duration = value; }
    }
}
