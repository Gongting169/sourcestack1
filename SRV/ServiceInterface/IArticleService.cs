using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ServiceInterface
{
    public interface IArticleService
    {
        int Publish(ArticleNewModel articleNewModel/*, int? currentUserId*/);
        ArticleSingleModel GetById(int id);
    }
}
