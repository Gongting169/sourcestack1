using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities 
{
    public class Email:Entity
    {
        public string Name { get; set; }
        public string Captcha { get; set; }
        public bool Enable { get; set; }
    }
}
