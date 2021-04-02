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
    public class CommentService : BaseService, ICommentService
    {
        private CommentRepository commentRepository;
        private ArticleRepository articleRepository;
        public CommentService()
        {
            commentRepository = new CommentRepository(Context);
            articleRepository = new ArticleRepository(Context);
        }


        public CommentModel GetById(int id)
        {
            Comment comment = commentRepository.GetRelevance(id).SingleOrDefault();        
            CommentModel model = mapper.Map<CommentModel>(comment);
            model.PublishTime = comment.PublishTime.ToString("yyyy年MM月dd日 hh点mm分");
            return model;
        }


        public int SaveComment(CommentModel model, int aId)
        {
            Comment comment = mapper.Map<Comment>(model);
            int amount = commentRepository.GetCountById(aId);
            Article article = articleRepository.Find(aId);
            comment.Publish();
            comment.Article = article;
            comment.Author = GetCurrentUser();
            comment.Location = amount + 1;
            commentRepository.Save(comment);
            return comment.Id;
        }
    }
}
