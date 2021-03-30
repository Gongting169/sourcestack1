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
        private KeywordRepository keywordRepository;
        private ArticleSingleModel singleModel;
        private AppraiseRepository appraiseRepository;
        private CommentRepository commentRepository;
        public ArticleService()
        {
            articleRepository = new ArticleRepository(Context);
            userRepository = new UserRepository(Context);
            keywordRepository = new KeywordRepository(Context);
            appraiseRepository = new AppraiseRepository(Context);
            commentRepository = new CommentRepository(Context);
            singleModel = new ArticleSingleModel();
        }
        public int Publish(ArticleNewModel articleNewModel)
        {
            if (GetCurrentUser() == null)
            {
                throw new ArgumentException(" 当前用户参数发生异常");
            }
            string[] container = articleNewModel.Keywords.Split(' ');
            Article article = mapper.Map<Article>(articleNewModel);
            article.Publish();
            article.Author = GetCurrentUser();
            article.KeyWords = new List<Keyword>();
            for (int i = 0; i < container.Length; i++)
            {
                Keyword keyword = keywordRepository.GetByName(container[i]);
                if (keyword == null)
                {
                    keyword = new Keyword();
                    keyword.Name = container[i];
                }//else nothing
                keyword.Used++;
                article.KeyWords.Add(keyword);
            }
            articleRepository.Save(article);
            return article.Id;
        }
        public ArticleSingleModel GetById(int id)
        {
            Article article = articleRepository.GetRelevance(id).SingleOrDefault();         
            singleModel = mapper.Map<ArticleSingleModel>(article);
            return singleModel;
        }
        public IList<ArticleModel> GetAllArticles()
        {
            IList<ArticleModel> models = mapper.Map<IList<ArticleModel>>(articleRepository.GetAllArticles());
            return models;
        }
        public ArticleSingleModel GetPreOrNextArticleId(int id)//获取上一篇和下一篇文章
        {
            Article preArticle = articleRepository.GetPreviousArticleId(id).FirstOrDefault();
            Article nextArticle = articleRepository.GetNextArticleId(id).FirstOrDefault();
            singleModel.PreArticleId = Convert.ToString(preArticle.Id);
            singleModel.PreArticleTitle = preArticle.Title;

            singleModel.NextArticleId = Convert.ToString(nextArticle.Id);
            singleModel.NextArticleTitle = nextArticle.Title;
            return singleModel;
        }

        public string GetAuthorById(int id)
        {
            return articleRepository.GetAuthorNameById(id).SingleOrDefault();
        }
    }
}
