using Glimpse.AspNet.Tab;
using ProdService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ViewModel;

namespace MVC.Controllers
{
    public class RegisterController : Controller
    {
        private UserService userService;
        public RegisterController()
        {
            userService = new UserService();
        }
        [HttpPost]
        public ActionResult Home(RegisterModel registerModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    TempData["e"] = ModelState;
            //    return RedirectToAction(nameof(Home));
            //}
            //if (registerModel.ComfirmPassword != registerModel.Password)
            //{
            //    ModelState.AddModelError(nameof(registerModel.ComfirmPassword), "两次输入的密码不一致");
            //    return RedirectToAction(nameof(Home));
            //}
            //if (userRepository.GetByName(registerModel.Name) != null)
            //{
            //    ModelState.AddModelError(nameof(registerModel.Name), " 输入的用户名已重复");
            //    return RedirectToAction(nameof(Home));
            //}
            //if (userRepository.GetByName(registerModel.InvitedBy) == null)
            //{
            //    ModelState.AddModelError(nameof(registerModel.InvitedBy), " 邀请人不存在");
            //    return RedirectToAction(nameof(Home));
            //}
            //if (userRepository.GetByInvitedCode(registerModel.InvitedCode) == null)
            //{
            //    ModelState.AddModelError(nameof(registerModel.InvitedCode), " 邀请人的邀请码不存在");
            //    return RedirectToAction(nameof(Home));
            //}
            //User user = new User()
            //{
            //    Name = registerModel.Name,
            //    Password = registerModel.Password
            //};
            //user.Register();
            //int id = userRepository.Save(user);
            return View();
        }
        [HttpGet]
        public ActionResult Home()
        {
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            return View();
        }
    }
}