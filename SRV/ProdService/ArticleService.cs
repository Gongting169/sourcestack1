using AutoMapper;
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
    public class ArticleService : BaseService, IArticleService
    {
        private UserRepository userRepository;
        private ArticleRepository articleRepository;
        public ArticleService()
        {
            articleRepository = new ArticleRepository(Context);
            userRepository = new UserRepository(Context);
        }

        public ArticleSingleModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public int Publish(ArticleNewModel articleNewModel/*, int currentUserId*/)
        {
            if (GetCurrentUser() == null)
            {
                throw new ArgumentException("");
            }
            Article article1 = articleRepository.Find(GetCurrentUser().Id);

            User author = GetCurrentUser();           
            ArticleNewModel model = mapper.Map<ArticleNewModel>(article1);
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
            return article.Id;
        }

        //public int Publish(ArticleNewModel articleNewModel/*, int? currentUserId*/)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
