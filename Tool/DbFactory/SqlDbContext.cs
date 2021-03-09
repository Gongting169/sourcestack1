using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("18BANG")
        {
            Database.Log = Console.WriteLine;
            Database.Log = s => Debug.Write(s);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Suggest> Suggests { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Appraise> Appraises { get; set; }
        public DbSet<Keyword> KeyWords { get; set; }
        public DbSet<Summary> Summaries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BPoint> BPoints { get; set; }
        public DbSet<BMoney> BMoney { get; set; }

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
