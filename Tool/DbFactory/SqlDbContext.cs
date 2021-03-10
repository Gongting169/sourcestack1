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
        public DbSet<User> User { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Problem> Problem { get; set; }
        public DbSet<Suggest> Suggest { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Appraise> Appraise { get; set; }
        public DbSet<Keyword> KeyWord { get; set; }
        public DbSet<Summary> Summarie { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<BPoint> BPoint { get; set; }
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
