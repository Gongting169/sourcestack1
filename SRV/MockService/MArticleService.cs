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
        public ArticleSingleModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Publish(ArticleNewModel articleNewModel, int currentUserId)
        {
            throw new NotImplementedException();
        }
    }
}
