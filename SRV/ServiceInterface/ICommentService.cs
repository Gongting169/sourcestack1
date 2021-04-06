using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ServiceInterface
{
    public interface ICommentService
    {
        CommentModel GetById(int id);
        int Save(CommentModel model, int aId);
        UserModel GetAuthorBy(int id);
        //ChildCommentModel SaveReply(ChildCommentModel model);
    }
}
