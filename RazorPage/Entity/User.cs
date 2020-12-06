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
        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }

        [MaxLength(20, ErrorMessage = "密码的长度不能小于4,不能大于20")]
        [MinLength(4, ErrorMessage = "密码的长度不能小于4，不能大于20")]
        public string Password { get; set; }

        [Required(ErrorMessage ="邀请人不能为空")]
        public User InvitedBy { get; set; }
        [MaxLength(4,ErrorMessage ="邀请码的长度只能为4")]
        [RegularExpression("[0 - 9] * ")]
        public string InvitedCode { get; set; }
        public int BCredit { get; set; }
        public int Reward { get; set; }
        public void Register()
        {
            InvitedBy.InvitedCode += 10;
        }




    }
}
