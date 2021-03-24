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

        public IQueryable<Article> GetPreviousArticleId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("参数的值不能匹配");
            }
            if (id == 1)
            {
                return null;
            }
            else
            {
                return dbSet.OrderByDescending(a => a.Id < id).Take(1);
            }
        }

        public IQueryable<Article> GetNextArticleId(int id)
        {
            int cId = dbSet.Where(a =>a.Id > id).Max(a => a.Id);
            if (id < cId)
            {
                return dbSet.Where(a => a.Id > id).OrderBy(a => a.Id).Take(1);
            }
            else
            {
                if (id == cId)
                {
                    return null;
                }
                else
                {
                    throw new ArgumentException("参数的值不能匹配");
                }
            }
        }




    }
}
