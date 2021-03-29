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
        private IAppraiseService appraiseService;
        public ArticleController()
        {
            articleService = new SRV.ProdService.ArticleService();
            userService = new SRV.ProdService.UserService();
            appraiseService = new SRV.ProdService.AppraiseService();
        }
        [HttpPost]
        public ActionResult New(ArticleNewModel articleNewModel)//没有登录不应该访问，差needlogon
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", " 请输入正确的格式");
                return View();
            }
            int articleId = articleService.Publish(articleNewModel);
            return RedirectToAction(nameof(Single), new { id = articleId });
        }
        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Index(int articleId)
        {
            List<ArticleModel> models = (List<ArticleModel>)articleService.GetAllArticles();
            return View(models);
        }
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Single(int id)
        {
            ArticleSingleModel singleModel = new ArticleSingleModel();
            singleModel = articleService.GetById(id);
            singleModel = articleService.GetPreOrNextArticleId(id);
            return View(singleModel);
        }

        public JsonResult GetArticleUserInfo(string aId, string direction)
        {
            
            UserModel user = userService.SwitchCurrentUser();
            ArticleSingleModel singleModel = new ArticleSingleModel();
            singleModel.AuthorName = articleService.GetAuthorById(Convert.ToInt32(aId));
            if (singleModel.AuthorName == user.Name)
            {
                throw new Exception("作者不能点赞自己的文章");
            }
            if (direction == "1")//点赞
            {
                // do nothing 
            }
            else
            {
                // do nothing    //点踩 多余 但不知道怎么办
            }
            int appraiseId = appraiseService.SaveAgreeOrDisagree(Convert.ToInt32(aId), direction);
            singleModel = appraiseService.GetById(appraiseId);
            singleModel.CurrentUser = user.Name;//把当前用户传递给前台，在前台进行比较
            return Json(singleModel);
        }
































    }
}