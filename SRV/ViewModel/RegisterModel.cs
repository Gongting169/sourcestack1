using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRV.ViewModel
{
    public class RegisterModel
    {
        public string Id { get; set; }
        [Remote("Check", "Register", HttpMethod = "post")]
        [StringLength(20, ErrorMessage = "* 用户名的长度不能大于20")]
        [Required(ErrorMessage = "* 用户名不能为空")]
        public string Name { get; set; }

        [StringLength(25, ErrorMessage = "* 密码的长度不能大于20,小于4", MinimumLength = 4)]
        [Required(ErrorMessage = "* 密码不能为空")]
        public string Password { get; set; }

        [MinLength(4, ErrorMessage = "* 验证码的长度只能为4")]
        [MaxLength(4, ErrorMessage = "* 验证码的长度只能为4")]
        [RegularExpression("[0-9]*", ErrorMessage = "* 验证码只能为4位数字")]
        [Required(ErrorMessage = "* 邀请码不能为空")]
        public string InvitedCode { get; set; }


        [MaxLength(20, ErrorMessage = "* 邀请人的长度不能大于20")]
        [Required(ErrorMessage = "* 邀请人不能为空")]
        public string InvitedByName { get; set; }

        [MinLength(4, ErrorMessage = "* 验证码的长度只能为4")]
        [MaxLength(4, ErrorMessage = "* 验证码的长度只能为4")]
        [Required(ErrorMessage = "* 验证码不能为空")]
        public string Captcha { get; set; }

        [StringLength(25, ErrorMessage = "* 确认密码的长度不能小于4,大于20", MinimumLength = 1)]
        [Required(ErrorMessage = "* 确认密码不能为空")]
        [System.ComponentModel.DataAnnotations.Compare(nameof(Password), ErrorMessage = "* 密码与确认密码不一致")]
        public string ComfirmPassword { get; set; }



    }
}