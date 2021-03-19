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
        public int Publish(ArticleNewModel articleNewModel)
        {
            if (GetCurrentUser() == null)
            {
                throw new ArgumentException(" 当前用户参数发生异常");
            }
            Article article = mapper.Map<Article>(articleNewModel);
            article.PublishTime = DateTime.Now;
            article.Author.Id = GetCurrentUser().Id;//容易理解
            //Author = GetCurrentUser();//          
            articleRepository.Save(article);
            return article.Id;
        }
        public ArticleSingleModel GetById(int id)
        {
            Article article = articleRepository.Find(id);
            ArticleSingleModel singleModel = mapper.Map<ArticleSingleModel>(article);
            return singleModel;
        }
        public IList<ArticleModel> GetAllArticle()
        {
            IList<ArticleModel> models = mapper.Map<IList<ArticleModel>>(articleRepository.GetAllArticle());
            return models ;
        }
    }
}
