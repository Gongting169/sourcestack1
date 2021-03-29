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


        public IQueryable<Appraise> GetAppraiseRelevance(int id)
        {
            return dbSet.Where(a => a.Id == id);
        }
        public IQueryable<Appraise> GetArticleAppraise(int aId)
        {
            return dbSet.Where(a => a.Article.Id == aId);
        }

        public int Attach(Appraise appraise)
        {
            //dbSet.Attach(appraise);
            context.SaveChanges();
            return appraise.Id;
        }










    }
}
