using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SRV.ViewModel 
{
    public class LogOnModel
    {
        [MaxLength(20,ErrorMessage ="* 用户名的长度不能超过20")]
        [Required(ErrorMessage ="* 用户名不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage ="* 密码不能为空")]
        [StringLength(20,ErrorMessage ="* 密码的长度不能小于4,不能大于20",MinimumLength =4)]
        public string Password { get; set; }

        [Required(ErrorMessage ="* 验证码不能为空")]
        [StringLength(4,ErrorMessage ="* 验证码的长度只能等于4",MinimumLength =4)]
        public string Captcha { get; set; }
        public bool RememberMe { get; set; }
    }
}