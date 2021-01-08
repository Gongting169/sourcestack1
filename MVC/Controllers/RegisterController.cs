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
            userService.RegisterValidate(registerModel);
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