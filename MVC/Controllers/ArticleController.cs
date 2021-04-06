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
            return View(singleModel);
        }


        /// <summary>
        /// 文章的点赞和点踩
        /// </summary>
        /// <param name="aId"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public JsonResult ArticleAppraise(int  id, string direction)
        {
            UserModel user = userService.GetCurrentUserModel();
            UserModel voter = articleService.GetAuthorBy(id); 
            if (user == voter)
            {
                throw new Exception("自己不能评价自己的文章");
            }
            if (direction == "1")
            {
                return Json(appraiseService.ArticleAgree(id, direction), JsonRequestBehavior.AllowGet);            
            }
            else
            {
                return Json(appraiseService.ArticleDisagree(id,direction), JsonRequestBehavior.AllowGet);             
            }
        }


        /// <summary>
        /// 发布一篇文章的评论
        /// </summary>
        /// <param name="html"></param>
        /// <param name="aId"></param>
        /// <returns></returns>
        public PartialViewResult PublishComment(string html, int  aId)
        {
            CommentModel model = new CommentModel();
            model.Body = html;
            int commentId = commentService.Save(model, aId);
            model = commentService.GetById(commentId);
            return PartialView("Single/_PublishComment", model);
        }


        /// <summary>
        /// 评论的点赞和点踩
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public JsonResult CommentAppraise(int id, string direction)
        {
            UserModel user = userService.GetCurrentUserModel();
            UserModel voter = commentService.GetAuthorBy(id);
            if (user == voter)
            {
                throw new Exception("自己不能评价自己的文章");
            }
            if (direction == "1")
            {
                return Json(appraiseService.CommentAgree(id, direction), JsonRequestBehavior.AllowGet);            
            }
            else
            {
                return Json(appraiseService.CommentDisagree(id, direction), JsonRequestBehavior.AllowGet);               
            }
        }


        /// <summary>
        /// 能够回复别人的评论
        /// </summary>
        /// <returns></returns>
        //[ChildActionOnly]
        //public PartialViewResult _CommentReply(ChildCommentModel model)
        //{
        //    return PartialView("/Single/_CommentReply.cshtml", commentService.SaveReply(model));
        //}




























    }
}