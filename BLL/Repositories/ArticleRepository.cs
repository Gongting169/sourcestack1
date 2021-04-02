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

        public IList<Article> GetAllArticles()
        {
            return dbSet.Take<Article>(dbSet.Count<Article>()).ToList();
        }

        public IQueryable<Article> GetPreviousArticleId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("参数的值不能匹配");
            }
            if (id == 1)//不能返回null 
            {
                return dbSet.Where(a => a.Id == id).Take(1);
            }
            else
            {
                return dbSet.Where(a => a.Id < id).OrderByDescending(a => a.Id).Take(1);
            }
        }

        public IQueryable<Article> GetNextArticleId(int id)
        {
            int cId = dbSet.Max(a => a.Id);
            if (id < cId)
            {
                return dbSet.Where(a => a.Id > id).OrderBy(a => a.Id).Take(1);
            }
            else
            {
                if (id == cId)// 返回null不行
                {
                    return dbSet.Where(a => a.Id == id).OrderBy(a => a.Id).Take(1);
                }
                else
                {
                    throw new ArgumentException("参数的值不能匹配");
                }
            }
        }

        public IQueryable<Article> GetRelevance(int id)
        {
            return dbSet.Where(a => a.Id == id);
        }


        public IQueryable<string> GetAuthorNameById(int id)
        {
            return dbSet.Where(a => a.Id == id).Select(a => a.Author.Name);
        }

    }
}
