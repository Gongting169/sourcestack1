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


        public int Save(CommentModel model, int aId)
        {
            Comment comment = mapper.Map<Comment>(model);
            comment.Publish();
            comment.Article = articleRepository.Find(aId);
            comment.Author = GetCurrentUser();
            commentRepository.Save(comment);
            return comment.Id;
        }


        //public ChildCommentModel SaveReply(ChildCommentModel model)
        //{
        //    Comment commentReply = mapper.Map<Comment>(model);
        //    Comment comment = commentRepository.Find(model.Id);
        //    comment.Body = model.Reply.Body;
        //    commentReply.Publish();
        //    commentReply.Reply = comment;
        //    commentReply.Author = GetCurrentUser();
        //    int replyId = commentRepository.Save(commentReply);
        //    Comment saveCommentReply = commentRepository.Find(replyId);
        //    ChildCommentModel childComment = mapper.Map<ChildCommentModel>(saveCommentReply);
        //    return childComment;
        //}
    }
}
