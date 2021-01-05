using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository :BaseRepository<User>
    {

        public void Find(int id) 
        {
        
        } 
        public void GetByName(string name)
        {

        }
    }
}
