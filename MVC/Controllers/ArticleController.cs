using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult New(ArticleNewModel articleNewModel)
        {
            return View();
        }

        public ActionResult Index(ArticleModel articleModel)
        {
            return View();
        }
    }
}