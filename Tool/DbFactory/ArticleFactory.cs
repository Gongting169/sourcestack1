using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class ArticleFactory
    {
        internal static void Create()
        {
            Article article = new Article() 
            {
                Author = UserFactory.LiSi,
            
            };

        }
    }
}
