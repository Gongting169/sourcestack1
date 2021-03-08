using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModel
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string InvitedCode { get; set; }
        public string InvitedByName { get; set; }
        public string Captcha { get; set; }
        public string ComfirmPassword { get; set; }
        public bool RememberMe { get; set; }

    }
}
