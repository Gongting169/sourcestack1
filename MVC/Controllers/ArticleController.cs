using ProdService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace MVC.Controllers
{
    public class ArticleController : Controller
    {
        private ArticleService articleService;
        public ArticleController()
        {
            articleService = new ArticleService();
        }
        [HttpPost]
        public ActionResult New(ArticleNewModel articleNewModel)
        {
            int currentUserId = 1;
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", " 请输入正确的格式");
                return View();
            }
            articleService.Publish(articleNewModel, currentUserId);
            return View();
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Index(ArticleModel articleModel)
        {
            return View();
        }
    }
}