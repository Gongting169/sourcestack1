using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Message : Entity
    {
        public string Kind { get; set; }
        public bool Selected { get; set; }
        public DateTime CreateTime { get; set; }
        public string Content { get; set; }
    }
}
