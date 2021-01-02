using Glimpse.AspNet.Tab;
using MVC.Models;
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
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Home(RegisterModel registerModel )
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }
            //if ( != registerModel.Password)
            //{
            //    ModelState.AddModelError(nameof(ConfirmPassword), "两次输入的密码不一致");
            //}
            //if (NewUser.InvitedBy == null)
            //{
            //    ModelState.AddModelError(nameof(NewUser.InvitedBy), "邀请人不存在");
            //}
            //if (NewUser.InvitedBy.InvitedCode.Length == 0)
            //{
            //    ModelState.AddModelError(nameof(NewUser.InvitedBy.InvitedCode), "邀请人的邀请码不存在");
            //}
            return View();
        }
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }




    }
}