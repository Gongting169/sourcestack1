using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fg.Controllers
{
    public class ArticleSingleController : Controller
    {
        // GET: ArticleSingle
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Single(int id)
        {
            //ArticleSingleModel singleModel = articleRepository.GetById(id);
            return View();
        }
    }
}