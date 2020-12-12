using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    [BindProperties]
    public class Article : Entity
    {
        public DateTime PublishTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public IList< Comment> Comments { get; set; }
        public IList<Appraise> Appraises { get; set; }

    }
}
