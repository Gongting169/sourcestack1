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

        public LogController()
        {
            userService = new SRV.ProdService.UserService();
            //userService = new SRV.MockService.MUserService();
        }
        [HttpPost]
        public ActionResult On(LogOnModel logOnModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    TempData["e"] = ModelState;
            //    return RedirectToAction(nameof(On));
            //}
            //if (userRepository.GetByName(logOnModel.Name) == null)
            //{
            //    ModelState.AddModelError(nameof(logOnModel.Name), "用户名不存在");
            //    return View();
            //}
            //if (logOnModel.Password != userRepository.GetByPassword(logOnModel.Password).ToString())
            //{
            //    ModelState.AddModelError(nameof(logOnModel.Password), "输入的密码或用户名错误");
            //    return View();
            //}
            return View(new LogOnModel() { RememberMe = true });
        }
        [HttpGet]
        public ActionResult On()
        {
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            return View();
        }



    }
}