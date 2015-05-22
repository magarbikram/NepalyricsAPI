using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class Lyrics
    {
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual IList<Lyricist> Lyricists { get; set; }
        public virtual User PostedBy { get; set; }
        public virtual IList<User> Contributers { get; set; }

        public virtual byte[] Version { get; set; }
    }
}
