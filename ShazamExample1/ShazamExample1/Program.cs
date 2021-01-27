using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Artist Outkast = new Artist();
            Outkast.Name = "Outkast";
            Song s1 = new Song();
            s1.Artist1 = Outkast;
            s1.Duration = 71f;
            s1.SongTitle = "Hold On, Be Strong";

            Song s2 = new Song();
            s2.Artist1 = Outkast;
            s2.Duration = 349f;
            s2.SongTitle = "Return of the 'G'";

            Song s3 = new Song();
            s3.Artist1 = Outkast;
            s3.Duration = 324f;
            s3.SongTitle = "Rosa Parks";
            Release aq = new Release();

            aq.ReleaseDate = new DateTime(1998, 9, 29, 9, 0, 0);
            aq.ReleaseTitle = "Aquemni";
            aq.thisArtist = Outkast;
            aq.thisGenre = Genre.Rap;
            aq.thisReleaseType = ReleaseType.Album;



        }
    }
}
