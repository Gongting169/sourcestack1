
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
    public class ArticleController :BaseController 
    {
        private IArticleService articleService;
        private IUserService userService;
        public ArticleController()
        {
            //articleService = new SRV.MockService.MArticleService();
            articleService = new SRV.ProdService.ArticleService();
            userService = new SRV.ProdService.UserService();
            //userService = new SRV.MockService.MUserService();
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
     
            return RedirectToAction("New", new { id = currentUserId1 });
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