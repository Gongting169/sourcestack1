using Glimpse.AspNet.Tab;
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
        public ActionResult Home(/*int id*/)
        {
            return View();
        }
    }
}