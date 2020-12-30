using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int InvitedCode { get; set; }
        public User InvitedBy { get; set; }
        public string Captcha { get; set; }
        public string ComfirmPassword { get; set; }
    }
}