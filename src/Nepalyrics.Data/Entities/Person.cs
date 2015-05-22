using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class Person
    {
        public virtual long PersonId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string BriefProfile { get; set; }
        public virtual string FullProfile { get; set; }
        public virtual string ProfileImage { get; set; }
        public virtual IList<string> ProfileImages { get; set; }
        public virtual string CoverImage { get; set; }
        public virtual IList<string> CoverImages { get; set; }

        public virtual byte[] Version { get; set; }
    }
}
