using Glimpse.AspNet.Tab;
using SRV.ProdService;
using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC.Controllers
{
    public class RegisterController : Controller
    {
        private IUserService userService;
        public RegisterController()
        {
            //userService = new SRV.ProdService.UserService();
            userService = new SRV.MockService.MUserService();
        }
        [HttpPost]
        public ActionResult Home(RegisterModel registerModel)
        {
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
            cookie.Values.Add(Keys.Id ,userId.ToString());
            cookie.Values.Add(Keys.Password, registerModel.Password);
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
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            return View();
        }
    }
}