﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepalyrics.Data.Entities
{
    public class Singer:Person
    {
        public virtual IList<Genre> Genres { get; set; }
    }
}
