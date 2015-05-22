using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class News
    {
        private virtual string Title { get; set; }
        private virtual string ThumbnailImage { get; set; }
        public virtual string Abstract { get; set; }
        public virtual string NewsURL { get; set; }
        public virtual IList<Person> RelatedPersons { get; set; }


        public virtual byte[] Version { get; set; }
    }
}
