using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult _user(int? level)
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult _logOnStatus()
        {
            if (true)
            {

            }
            return PartialView();
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}