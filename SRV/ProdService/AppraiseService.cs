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
    public class AppraiseService : BaseService, IAppraiseService
    {
        private AppraiseRepository appraiseRepository;
        private CommentRepository commentRepository;
        private ArticleRepository articleRepository;
        public AppraiseService()
        {
            appraiseRepository = new AppraiseRepository(Context);
            articleRepository = new ArticleRepository(Context);
            commentRepository = new CommentRepository(Context);
        }

        public AppraiseModel GetById(int id)
        {
            Appraise appraise = appraiseRepository.GetRelevanceBy(id).SingleOrDefault();
            AppraiseModel model = mapper.Map<AppraiseModel>(appraise);
            return model;
        }


        /// <summary>
        /// 文章的点赞和点踩
        /// </summary>
        /// <param name="id"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public int SaveArticle(int id, string direction)
        {
            Appraise appraise = new Appraise();
            appraise.Voter = GetCurrentUser();
            appraise.Article = articleRepository.Find(id); 
            if (direction == "1")
            {
                appraise.UpCount += 1;
            }
            else
            {
                appraise.DownCount += 1;
            }

            return appraiseRepository.Save(appraise);
        }


        /// <summary>
        /// 依据文章Id返回这篇文章点赞的数量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int ArticleAgree(int id, string direction)
        {
            SaveArticle(id, direction);
            return appraiseRepository.GetByArticle(id).Select(a => a.UpCount).Sum();
        }


        /// <summary>
        /// 依据文章Id返回这篇文章点踩的数量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int ArticleDisagree(int id, string direction)
        {
            SaveArticle(id, direction);
            return appraiseRepository.GetByArticle(id).Select(a => a.DownCount).Sum();
        }


       /// <summary>
       /// 评论的点赞和点踩
       /// </summary>
       /// <param name="id"></param>
       /// <param name="direction"></param>
       /// <returns></returns>
        public int SaveComment(int id, string direction)
        {
            Appraise appraise = new Appraise();
            appraise.Voter = GetCurrentUser();
            appraise.Comment = commentRepository.Find(id);
            if (direction == "1")
            {
                appraise.SupportCount += 1;
            }
            else
            {
                appraise.OpposeCount += 1;
            }
            return appraiseRepository.Save(appraise);
        }


        /// <summary>
        /// 依据评论Id返回这篇评论点赞的数量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int CommentAgree(int id, string direction)
        {
            SaveComment(id, direction);
            return appraiseRepository.GetByComment(id).Select(a => a.SupportCount).Sum();
        }


        /// <summary>
        /// 依据评论Id返回这篇评论点踩的数量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int CommentDisagree(int id, string direction)
        {
            SaveComment(id, direction);
            return appraiseRepository.GetByComment(id).Select(a => a.OpposeCount).Sum();
        }

    }
}
