using GLB.Global;
using MVC.Helpers;
using SRV.ProdService;
using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class LogController : Controller
    {
        private IUserService userService;
        private RegisterModel registerModel;
        public LogController()
        {
            registerModel = new RegisterModel();
            userService = new SRV.ProdService.UserService();
            //userService = new SRV.MockService.MUserService();
        }
        [HttpPost]
        public ActionResult On(LogOnModel logOnModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction(nameof(On));
            }
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            LogOnModel onModel = userService.GetByLogOnName(logOnModel.Name);
            if (onModel.Name == null)
            {
                ModelState.AddModelError(nameof(logOnModel.Name), "用户名不存在");
                return View();
            }
            if (logOnModel.Password != onModel.Password)
            {
                ModelState.AddModelError(nameof(logOnModel.Password), "输入的密码或用户名错误");
                return View();
            }
            int id = userService.GetIdByName(logOnModel.Name);
            string pwd = userService.GetPwdById(id);
            HttpCookie cookie = new HttpCookie(Keys.User);
            cookie.Values.Add(Keys.Id, id.ToString());
            cookie.Values.Add(Keys.Password, pwd.MD5EnCrypt());
            Response.Cookies.Add(cookie);
            if (logOnModel.RememberMe)
            {
                cookie.Expires = DateTime.Now.AddMonths(1);
            }// else nothing 
            return View();
        }
        [HttpGet]
        public ActionResult On()
        {
            return View();
        }
        public ActionResult Off()
        {
            return View();
        }

    }
}