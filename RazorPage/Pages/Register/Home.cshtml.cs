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
        private  UserRepository userRepository;
        public RegisterModel()
        {
            userRepository = new UserRepository();
        }
        public User NewUser { get; set; }
        public string ConfirmPassword { get; set; }
        public void OnGet()
        {
            //AnchorTagHelper
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            userRepository.Save(NewUser);
        }
    }
}
