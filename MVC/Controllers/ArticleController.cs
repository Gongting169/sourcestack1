
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
    public class ArticleController : Controller
    {
        private IArticleService articleService;
        public ArticleController()
        {
            articleService = new ArticleService();
        }
        [HttpPost]
        public ActionResult New(ArticleNewModel articleNewModel)
        {
            int currentUserId1 = 1;
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", " 请输入正确的格式");
                return View();
            }
            bool hasLogIn = int.TryParse(Request.Cookies[Keys.User].Value, out int currentUserId);
            if (hasLogIn)
            {
                //int id = articleService.Publish(articleNewModel,currentUserId);
            }
            else
            {

            }
            return RedirectToAction("New", new { id = currentUserId });
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