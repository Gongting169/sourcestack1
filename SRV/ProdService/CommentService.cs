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
        public CommentService()
        {
            commentRepository = new CommentRepository(Context);
        }


        public CommentModel GetById(int id)
        {
            Comment comment = commentRepository.GetComment(id).SingleOrDefault();
            CommentModel  model = mapper.Map<CommentModel>(comment);
            return model;
        }
    }
}
