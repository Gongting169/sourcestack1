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
        public void Publish(ArticleNewModel articleNewModel, int currentUserId)
        {
            throw new NotImplementedException();
        }
    }
}
