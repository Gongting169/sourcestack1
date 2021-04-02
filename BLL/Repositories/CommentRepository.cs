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

        public IQueryable<Comment> GetOderByDescLocation(int id)
        {
            return dbSet.Where(c => c.Article.Id == id).OrderByDescending(c => c.Location);
        }

        public IQueryable<Comment> GetComment(int aId)
        {
            return dbSet.Where(a => a.Article.Id == aId);
        }


        public IQueryable<Comment> GetRelevance(int id)
        {
            return dbSet.Where(a => a.Id == id);
        }
          
        public int  GetCountById(int aId)
        {
           return dbSet.Where(a => a.Article.Id == aId).Count<Comment>();
        }

    }
}
