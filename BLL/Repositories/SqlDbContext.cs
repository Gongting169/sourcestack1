using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories 
{
    public class SqlDbContext :DbContext
    {
        public SqlDbContext():base("17bang")
        {

        }

        //public DbSet<User> Users { get; set; }
        //public DbSet<Email> Emails { get; set; }
        //public DbSet<Article> Articles { get; set; }
        //public DbSet<Problem> Problems { get; set; }
        //public DbSet<Suggest> Suggests { get; set; }
        //public DbSet<Content> Contents { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Appraise> Appraises { get; set; }
        //public DbSet<KeyWord> KeyWords { get; set; }
        //public DbSet<Summary> Summaries { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<BPoint> BPoints { get; set; }
        //public DbSet<BMoney> BMoney { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {





            base.OnModelCreating(modelBuilder);
        }


    }
}
