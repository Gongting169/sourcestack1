using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class AppraiseRepository : BaseRepository<Appraise>
    {
        public AppraiseRepository(SqlDbContext context) : base(context)
        {
        }


        public IQueryable<Appraise> GetRelevanceBy(int id)
        {
            return dbSet.Where(a => a.Id == id);
        }


        public IQueryable<Appraise> GetByArticle(int id)
        {
            return dbSet.Where(a => a.Article.Id == id);
        }

        public IQueryable<Appraise> GetByComment(int id)
        {
            return dbSet.Where(a => a.Comment.Id == id);
        }

  






    }
}
