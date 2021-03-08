using GLB.Global;
using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class RegisterController : Controller
    {
        private IUserService userService;
        public RegisterController()
        {
            userService = new SRV.ProdService.UserService();
            //userService = new SRV.MockService.MUserService();
        }
        [HttpPost]
        public ActionResult Home(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction("Home");
            }
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            if (registerModel.ComfirmPassword != registerModel.Password)
            {
                ModelState.AddModelError(nameof(registerModel.ComfirmPassword), "两次输入的密码不一致");
                return RedirectToAction("Home");
            }
            if (userService.GetByName(registerModel.Name) != null )
            {
                ModelState.AddModelError(nameof(registerModel.Name), " 输入的用户名已重复");
                return RedirectToAction("Home");
            }
            if (userService.GetByName(registerModel.InvitedByName) == null)
            {
                ModelState.AddModelError(nameof(registerModel.InvitedByName), " 邀请人不存在");
                return RedirectToAction("Home");
            }
            if (userService.GetByInvitedCode(registerModel.InvitedCode) == null)
            {
                ModelState.AddModelError(nameof(registerModel.InvitedCode), " 邀请人的邀请码不存在");
                return RedirectToAction("Home");
            }

            //bool hasLogIn = int.TryParse(Request.Cookies[Keys.User].Value, out int currentUserId);
            //if (hasLogIn)
            //{
            //    //int id = userService.RegisterValidate(registerModel, currentUserId);
            //}
            //else
            //{

            //}
            int userId = userService.Register(registerModel);
            HttpCookie cookie = new HttpCookie(Keys.User, userId.ToString());
            cookie.Values.Add(Keys.Id, userId.ToString());
            cookie.Values.Add(Keys.Password, registerModel.Password.MD5EnCrypt());
            Response.Cookies.Add(new HttpCookie(Keys.User, userId.ToString()));
            //userService.RegisterValidate(registerModel);
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
            return View();
        }
    }
}