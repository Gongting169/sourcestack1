using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public class Article:Entity
    {
        public DateTime PublishTime { get; set; }
        public string Title { get; set; }
        
    }
}
