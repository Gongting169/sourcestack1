using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public string InvitedCode { get; set; }
        //public Email Email { get; set; }
        //public int? EmailId { get; set; }
        public int BMoney { get; set; }
        public int BPoints { get; set; }

        public void Register()
        {
            BMoney += new Random().Next(10);
            BPoints += new Random().Next(10);
        }
    }
}
