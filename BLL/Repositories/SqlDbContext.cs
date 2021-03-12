using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SqlDbContext<T> : SqlDbContext where T : class
    {
        public DbSet<T> Entities { get; set; }
    }

    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("18BANG")
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Article>();
            modelBuilder.Entity<Comment>();
            modelBuilder.Entity<Problem>();
            modelBuilder.Entity<Suggest>();
            modelBuilder.Entity<Keyword>();
            modelBuilder.Entity<Message>();
            modelBuilder.Entity<Summary>();
            modelBuilder.Entity<Email>();
            modelBuilder.Entity<Content>();
            modelBuilder.Entity<Category>();
            modelBuilder.Entity<BMoney>();
            modelBuilder.Entity<BPoint>();
            modelBuilder.Entity<Appraise>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
