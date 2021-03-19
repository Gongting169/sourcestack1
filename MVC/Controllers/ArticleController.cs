using MVC.Helpers;
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
        private IUserService userService;
        public ArticleController()
        {
            articleService = new SRV.ProdService.ArticleService();
            userService = new SRV.ProdService.UserService();
        }
        [HttpPost]
        public ActionResult New(ArticleNewModel articleNewModel)//没有登录不应该访问，差needlogon
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", " 请输入正确的格式");
                return View();
            }
            int articleId = articleService.Publish(articleNewModel/*CookieHelper.GetCurrentUserId()*/);
            return RedirectToAction(nameof(Single), new { id = articleId });
            
        }
        [HttpGet]
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Index(int articleId)
        {
            List<ArticleModel> models = (List<ArticleModel>)articleService.GetAllArticle();
            return View(models);
        }
        public ActionResult Single(int id)
        {
            ArticleSingleModel singleModel = articleService.GetById(id);
            return View(singleModel);
        }

    }
}