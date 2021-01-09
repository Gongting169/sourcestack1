using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ArticleSingleController : Controller
    {
        // GET: ArticleSingle
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Single(ArticleSingleModel singleModel )
        {
            return View();
        }
    }
}