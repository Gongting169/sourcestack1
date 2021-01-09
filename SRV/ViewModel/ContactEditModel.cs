using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SRV.ViewModel 
{
    public class ContactEditModel
    {
        public string QQ { get; set; }
        [Display(Name ="微信")]
        public string WeChat { get; set; }
        [Display(Name = "电话")]
        public string TelePhone { get; set; }
        [Display(Name = "其他")]
        public string Other { get; set; }
    }

    public enum Item
    {
        QQ,
        [Display(Name = "微信")]
        WeChat,
        [Display(Name = "电话")]
        TelePhone,
        [Display(Name = "其他")]
        Other
    }
}