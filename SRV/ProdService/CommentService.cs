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
        private UserRepository userRepository;
        public CommentService()
        {
            commentRepository = new CommentRepository(Context);
            articleRepository = new ArticleRepository(Context);
            userRepository = new UserRepository(Context);
        }

        /// <summary>
        /// 通过评论的id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserModel GetAuthorBy(int id)
        {
            User user = commentRepository.GetRelevanceBy(id).Select(c => c.Author).SingleOrDefault();
            return mapper.Map<UserModel>(user);
        }


        public CommentModel GetById(int id)
        {
            Comment comment = commentRepository.GetRelevanceBy(id).SingleOrDefault();
            CommentModel model = mapper.Map<CommentModel>(comment);
            return model;
        }

        /// <summary>
        ///发布一篇评论和能够回复别人评论
        /// </summary>
        /// <param name="model"></param>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public CommentModel Save(CommentModel model)
        {
            Comment comment = mapper.Map<Comment>(model);
            comment.Publish();
            comment.Author = GetCurrentUser();
            comment.Reply = commentRepository.Find(model.CommentId);   //当前被评论的Id
            comment.Article = articleRepository.Find(model.ArticleSingleModel.Id);//评论文章的Id
            CommentModel commentModel = GetById(commentRepository.Save(comment));
            return commentModel;
        }

    }
}
