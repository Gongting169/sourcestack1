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
        CommentModel Save(CommentModel model);
        UserModel GetAuthorBy(int id);
    }
}
