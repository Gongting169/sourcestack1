using BLL.Entities;
using BLL.Repositories;
using GLB.Global;
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
            var query = dbSet.Where(u => u.Name == name);
            return query.SingleOrDefault();

        }
        public User GetByPassword(string password)
        {
            var query = dbSet.Where(u => u.Password == password.MD5EnCrypt());
           return query.SingleOrDefault();
        }
        public User GetByInvitedCode(string invitedCode)
        {
            var user = dbSet.Where(u => u.InvitedBy.InvitedCode == invitedCode);
            return user.SingleOrDefault();
        }
        public User GetByInvitedBy(string invitedBy)
        {
            var query = dbSet.Where(u => u.InvitedBy.Name == invitedBy);
            return query.SingleOrDefault();

        }

        public List<User> GetSerializeName(string name1)
        {
            var query = dbSet
                .Where(u => u.InvitedBy.Name.StartsWith(name1.Trim()));
            return query.ToList();
        }

    }
}
