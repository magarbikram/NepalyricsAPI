using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nepalyrics.Data.Entities
{
    public class MusicCompany
    {
        public string Name { get; set; }
        public string Profile { get; set; }

        public virtual byte[] Version { get; set; }
    }
}
