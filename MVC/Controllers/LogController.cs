using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class LogController : Controller
    {
        [HttpPost]
        public ActionResult On(LogOnModel logOnModel)
        {
            HttpCookie cookie = new HttpCookie("LogOn");
            Response.Cookies.Add(cookie);
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction(nameof(On));
            }
            //if (user == null)
            //{
            //    ModelState.AddModelError(nameof(NewUser.Name), "用户名不存在");
            //    return;
            //}
            //if (user.Password != NewUser.Password)
            //{
            //    ModelState.AddModelError(nameof(NewUser.Password), "输入的密码或用户名错误");
            //}  

            return View(new LogOnModel() { RememberMe = true });
        }
        [HttpGet]
        public ActionResult On() 
        {
            if (TempData["e"] !=null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            return View();
        }


    }
}