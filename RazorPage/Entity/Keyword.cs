﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public class Keyword:Entity
    {
        public string Name { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
