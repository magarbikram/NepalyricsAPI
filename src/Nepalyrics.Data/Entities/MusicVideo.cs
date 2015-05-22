using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class MusicVideo
    {
        public enum Type { 
            Official,Cover,Other
        }
        public virtual string VideoURL { get; set; }
        public virtual Type MusicVideoType { get; set; }
        public virtual Song Song { get; set; }


        public virtual byte[] Version { get; set; }
    }
}
