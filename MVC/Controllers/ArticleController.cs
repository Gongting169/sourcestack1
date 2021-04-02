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
        private ICommentService commentService;
        public ArticleController()
        {
            articleService = new SRV.ProdService.ArticleService();
            userService = new SRV.ProdService.UserService();
            appraiseService = new SRV.ProdService.AppraiseService();
            commentService = new SRV.ProdService.CommentService();
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
            //return View(singleModel);
            return View("Single/Single", singleModel);
        }

        public JsonResult GetArticleUserInfo(string aId, string direction)
        {

            UserModel user = userService.GetCurrentUserModel();
            ArticleSingleModel singleModel = new ArticleSingleModel();
            singleModel.AuthorName = articleService.GetAuthorById(Convert.ToInt32(aId));
            if (singleModel.AuthorName == user.Name)
            {
                throw new Exception("作者不能点赞自己的文章");
            }
            int appraiseId = appraiseService.SaveAgreeOrDisagree(Convert.ToInt32(aId), direction);
            AppraiseModel appraise = appraiseService.GetById(appraiseId);
            singleModel.CurrentUser = user.Name;//把当前用户传递给前台，在前台进行比较
            return Json(new { singleModel.CurrentUser, appraise.DownCount, appraise.UPCount });
        }

        public PartialViewResult PublishComment(string html, string aId)//判断用户是否登录没有去做
        {
            ArticleSingleModel singleModel = new ArticleSingleModel();
            CommentModel model = new CommentModel();
            model.Body = html;
            int commentId = commentService.SaveComment(model, Convert.ToInt32(aId));
            model = commentService.GetById(commentId);
            return PartialView("Single/_PublishComment",model);
        }
































    }
}