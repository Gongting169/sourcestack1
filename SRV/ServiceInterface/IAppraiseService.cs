using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ServiceInterface
{
    public interface IAppraiseService
    {
        AppraiseModel GetById(int id);
        int SaveArticle(int id, string direction);
        int ArticleDisagree(int id, string direction);
        int ArticleAgree(int id, string direction);

        int SaveComment(int id, string direction);
        int CommentDisagree(int id, string direction);
        int CommentAgree(int id, string direction);
    }
}
