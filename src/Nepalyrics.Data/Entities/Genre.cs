using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class Genre
    {
        public virtual long GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
