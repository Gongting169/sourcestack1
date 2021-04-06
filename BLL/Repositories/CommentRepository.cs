using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CommentRepository : BaseRepository<Comment>
    {
        public CommentRepository(SqlDbContext context) : base(context)
        {
        }

        public IQueryable<Comment> GetByArticle(int id)
        {
            return dbSet.Where(a => a.Article.Id == id);
        }


        public IQueryable<Comment> GetRelevanceBy(int id)
        {
            return dbSet.Where(a => a.Id == id);
        }


    }
}
