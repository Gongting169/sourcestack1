using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository()
        {
            context = new SqlDbContext<User>();
        }
        public User GetByName(string name)
        {
            return context.Entities
                .Where(u => u.Name == name)
                .SingleOrDefault();
        }
        public User GetByPassword(string password)
        {
            return context.Entities
                .Where(u => u.Password == password)
                .SingleOrDefault();
        }
        public User GetByInvitedCode(int invitedCode)
        {
            return context.Entities
                .Where(u => u.InvitedBy .InvitedCode == invitedCode)
                .SingleOrDefault();
        }
        public User GetByInvited(string invitedBy)
        {
            return context.Entities
                .Where(u => u.InvitedBy.Name == invitedBy)
                .SingleOrDefault();
        }
    }
}
