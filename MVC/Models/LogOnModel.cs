using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class LogOnModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Captcha { get; set; }
        public bool RememberMe { get; set; }
    }
}