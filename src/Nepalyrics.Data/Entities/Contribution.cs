using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class Contribution
    {
        public enum ContributionType{
            Post, Modification, Spam
        }
        public virtual User Contributer { get; set; }
        public virtual Song Song { get; set; }
        public virtual ContributionType ContributionType { get; set; }

        public virtual byte[] Version { get; set; }
    }
}
