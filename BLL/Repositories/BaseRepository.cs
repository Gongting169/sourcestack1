using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BaseRepository<T> where T : class
    {
        protected SqlDbContext context;
        public BaseRepository()
        {
            context = new SqlDbContext();
        }


        public int Save(T entity)
        {
            //context.
            throw new NotImplementedException();
        }
        public void Delete(T entity)
        {

        }
    }
}
