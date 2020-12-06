using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sourcestack1.Entity;
using sourcestack1.Repository;

namespace sourcestack1.Pages.Register
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private UserRepository userRepository;
        public RegisterModel()
        {
            userRepository = new UserRepository();
        }
        public User NewUser { get; set; }
        
        public string ConfirmPassword { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (ConfirmPassword!= NewUser.Password)
            {
                ModelState.AddModelError(nameof(ConfirmPassword), "两次输入的密码不一致");
            }
            if ( NewUser.InvitedBy==null)
            {
                ModelState.AddModelError(nameof(NewUser.InvitedBy), "邀请人不存在");
            }
            if (NewUser.InvitedBy.InvitedCode.Length==0)
            {
                ModelState.AddModelError(nameof (NewUser.InvitedBy.InvitedCode),"邀请人的邀请码不存在");
            }

            if(!ModelState.IsValid)
            {
                return;
            }


            //userRepository.Save(NewUser);
            //NewUser.Register();
            //User invitedby = userRepository.GetByName(NewUser.InvitedBy.Name);
            //NewUser.InvitedBy = invitedby;
            //if (invitedby == null)
            //{

            //}
            //if (NewUser.InvitedBy.InvitedCode !=invitedby.InvitedCode)
            //{

            //}
        }
    }
}
