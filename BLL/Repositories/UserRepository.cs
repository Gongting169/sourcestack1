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
        public UserRepository(SqlDbContext context) : base(context)
        {
        }
        public User GetByName(string name)
        {
            return dbSet.Where(u => u.Name == name)
                .SingleOrDefault();
        }
        public User GetByPassword(string password)
        {
            return dbSet.Where(u => u.Password == password)
                .SingleOrDefault();
        }
        public User GetByInvitedCode(string invitedCode)
        {
            return dbSet.Where(u => u.InvitedBy.InvitedCode == invitedCode)
                .SingleOrDefault();
        }
        public User GetByInvitedBy(string invitedBy)
        {
            return dbSet.Where(u => u.InvitedBy.Name == invitedBy)
                .SingleOrDefault();
        }

        public List<User> GetSerializeName(string name1)
        {
            List<User> users = new List<User>();
            var query = dbSet
                .Where(u => u.InvitedBy.Name.StartsWith(name1.Trim()));
            return query.ToList();
        }

    }
}
