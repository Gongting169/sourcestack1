using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public class User : Entity
    {
        public IList<Article> Articles { get; set; }

        [Required(ErrorMessage = "* 用户名不能为空")]
        public string Name { get; set; }

        [StringLength(30,ErrorMessage ="密码的长度不能小于4，不能大于20",MinimumLength = 4)]//有一个bug
        [Required(ErrorMessage ="密码不能为空")]
        public string Password { get; set; }

        [Required(ErrorMessage ="* 邀请人不能为空")]
        public User InvitedBy { get; set; }

        [StringLength(4,ErrorMessage ="邀请码的长度只能为4",MinimumLength = 4)]
        [RegularExpression("[0 - 9] * ",ErrorMessage ="邀请码只能为4位数字")]
        [Required(ErrorMessage ="邀请码不能为空")]
        public string InvitedCode { get; set; }

        [StringLength(4, ErrorMessage = "邀请码的长度只能为4", MinimumLength = 4)]
        [Required(ErrorMessage ="验证码不能为空")]
        public string Captcha { get; set; }
        public int BCredit { get; set; }
        public int Reward { get; set; }
        public void Register()
        {
            InvitedBy.InvitedCode += 10;
        }




    }
}
