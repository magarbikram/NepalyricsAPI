using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class SongAlbum
    {
        public virtual IList<Song> Songs { get; set; }
        public virtual DateTime ReleasedDate { get; set; }
        public virtual MusicCompany Distributer { get; set; }
        public virtual string CoverPicture { get; set; }
    }
}
