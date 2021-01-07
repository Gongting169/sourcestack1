using BLL.Entities;
using BLL.Repositories;
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
        private UserRepository userRepository;
        private ArticleRepository articleRepository;
        public ArticleController()
        {
            SqlDbContext context = new SqlDbContext();
            articleRepository = new ArticleRepository(context);
            userRepository = new UserRepository(context);
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
            User author = userRepository.Find(currentUserId);
            Article article = new Article()
            {
                Title = articleNewModel.Title,
                Body = articleNewModel.Body,
                Author = author,
                KeyWords = articleNewModel.Keywords,
                Category = articleNewModel.Category,
                PublishTime = DateTime.Now,
            };
            //还有一个用户发布文章消耗帮帮币问题：
            articleRepository.Save(article);
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