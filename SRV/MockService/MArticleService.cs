using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.MockService
{
    public class MArticleService : IArticleService
    {
        public IList<ArticleModel> GetAllArticle()
        {
            throw new NotImplementedException();
        }

        public ArticleSingleModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Publish(ArticleNewModel articleNewModel, int currentUserId)
        {
            throw new NotImplementedException();
        }

        public int Publish(ArticleNewModel articleNewModel)
        {
            throw new NotImplementedException();
        }
    }
}
