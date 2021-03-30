using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class KeywordRepository : BaseRepository<Keyword>
    {
        public KeywordRepository(SqlDbContext context) : base(context)
        {
        }

        public Keyword GetByName(string name)
        {
            return dbSet.Where(k => k.Name == name).SingleOrDefault();
        }


        public IQueryable<Keyword> GetRelevance(int id)
        {
            return dbSet.Where(a => a.Id == id);
        }


    }
}
