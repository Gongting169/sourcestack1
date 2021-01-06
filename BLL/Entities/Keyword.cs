using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Keyword : Entity
    {
        public string Name { get; set; }
        public int Used { get; set; }
        public IList<Article> Articles { get; set; }
        public IList<Problem> Problems { get; set; }
    }
}
