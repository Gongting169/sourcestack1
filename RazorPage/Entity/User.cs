using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public class User:Entity
    {
        public IList<Article> Articles { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public string InvitedCode { get; set; }
        public int BCredit { get; set; }
        public int Reward { get; set; }
    }
}
