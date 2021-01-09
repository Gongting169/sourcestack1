using BLL.Entities;
using BLL.Repositories;
using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SRV.ProdService
{
    public class ArticleService:IArticleService
    {
        private UserRepository userRepository;
        private ArticleRepository articleRepository;
        public ArticleService()
        {
            SqlDbContext context = new SqlDbContext();
            articleRepository = new ArticleRepository(context);
            userRepository = new UserRepository(context);
        }
        public void Publish(ArticleNewModel articleNewModel, int currentUserId)
        {
            User author = userRepository.Find(currentUserId);
            Article article = new Article()
            {
                Title = articleNewModel.Title,
                Body = articleNewModel.Body,
                Author = author,
                //KeyWords = articleNewModel.Keywords,
                //Category = articleNewModel.Category, 
                PublishTime = DateTime.Now,
            };
            //还有一个用户发布文章消耗帮帮币问题：
            articleRepository.Save(article);

        }


    }
}
