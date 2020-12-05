using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public abstract class Content :Entity
    {
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime CreateTime { get; private set; }
        public DateTime PublishTime { get; set; }
    }
}
