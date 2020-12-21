using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.YqBang
{
    public class Email:Entity
    {
        public string Name { get; set; }
        public string Captcha { get; set; }
        public bool Enable { get; set; }
    }
}
