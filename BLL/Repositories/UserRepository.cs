﻿using BLL.Entities;
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
        //public void Publish(int id)
        //{
        //    context.
        //}
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
        public User GetByInvitedCode(int invitedCode)
        {
            return dbSet.Where(u => u.InvitedBy.InvitedCode == invitedCode)
                .SingleOrDefault();
        }
        public User GetByInvited(string invitedBy)
        {
            return dbSet.Where(u => u.InvitedBy.Name == invitedBy)
                .SingleOrDefault();
        }

    }
}
