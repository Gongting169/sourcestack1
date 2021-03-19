using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ArticleRepository : BaseRepository<Article>
    {
        public ArticleRepository(SqlDbContext context) : base(context)
        {
        }

        //找出所有文章放到列表页里面去
        public IList<Article> GetAllArticle()
        {
            return dbSet.Take<Article>(dbSet.Count<Article>()).ToList();
        }

    }
}
