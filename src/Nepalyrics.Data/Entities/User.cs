using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class User:Person
    {
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual Role Role { get; set; }
    }
}
