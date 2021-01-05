using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories 
{
    public class BaseRepository
    {
        protected  SqlDbContext context;
        public BaseRepository()
        {
            context = new SqlDbContext();
        }


        public int Save()
        {
            //context.
            throw new NotImplementedException();
        }
        public void Delete()
        {

        }
    }
}
