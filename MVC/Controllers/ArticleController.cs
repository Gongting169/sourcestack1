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
        // GET: Article
        public ActionResult Index(ArticleModel articleModel )
        {
            return View();
        }
    }
}