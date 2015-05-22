using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class Song
    {
        public virtual Singer Singer { get; set; }
        public virtual Lyrics Lyrics { get; set; }
        public virtual IList<Genre> Genres { get; set; }
        public virtual MusicVideo OfficialMusicVideo { get; set; }
        public virtual IList<MusicVideo> CoverVideos { get; set; }
        public virtual IList<MusicVideo> OtherVideos { get; set; }

        public virtual byte[] Version { get; set; }
    }
}
