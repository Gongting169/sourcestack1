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



       public  ArticleSingleModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
