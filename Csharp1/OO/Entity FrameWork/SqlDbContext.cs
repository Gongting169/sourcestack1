using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.Entity_FrameWork
{
    class SqlDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring =
                @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17bang; Integrated Security = True; Connect Timeout = 30;";
            optionsBuilder.UseSqlServer(connectionstring);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
