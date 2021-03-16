using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities 
{
    public class Content:Entity
    {
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime PublishTime 
        { 
            get => DateTime.Now; 
            set { } 
        }
    }
}
