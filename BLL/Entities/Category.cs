using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities 
{
    public class Category:Entity
    {
        public string Title { get; set; }
        public IList<Article> Articles { get; set; }
        public string Body { get; set; }
    }
}
