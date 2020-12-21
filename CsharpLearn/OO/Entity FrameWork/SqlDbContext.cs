using CSharplearn.OO.YqBang;
using CSharplearn.ProcedureObject.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.Entity_FrameWork
{
    class SqlDbContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Suggest> Suggests { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Appraise> Appraises { get; set; }
        public DbSet<KeyWord> KeyWords { get; set; }
        public DbSet<Summary> Summaries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring =
                @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17bang; Integrated Security = True; Connect Timeout = 30;";
            optionsBuilder
               .UseSqlServer(connectionstring)
               .EnableSensitiveDataLogging()
               .LogTo(
                (id, level) => level >= Microsoft.Extensions.Logging.LogLevel.Debug
                , log => Console.WriteLine(log));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("Register");  //将之前的User类名改为Register，但仍然能对应表User 
                u.Property(u => u.Name).HasColumnName("UserName").HasMaxLength(256);  //将之前的User属性Name改成UserName，但仍然能对应表User的列Name 将Name的长度限制为256 
                u.HasKey(s => s.Name);   //将User表的主键设置在Name列上 
                u.Property(u => u.Password).IsRequired();   //Password不能为空
                u.Ignore(u => u.FaildTry);    //User类中的属性FailedTry不用存储到数据库中 
                u.HasCheckConstraint("CK_CreateTime", "CreateTime >= '2020/1/1'"); //CreateTime不能小于2000年1月1日
                u.HasIndex(s => s.Name).IsUnique();  //给CreateTime属性添加一个非聚集唯一索引 
            });
            modelBuilder.Entity<User>().HasOne<Email>(u => u.Email).WithOne().HasForeignKey<User>(u => u.EmailId);
            //modelBuilder.Entity<Suggest>().ToTable("Suggests");
            //modelBuilder.Entity<Article>().ToTable("Articles");
            //modelBuilder.Entity<Problem>().ToTable("Problems");
            //modelBuilder.Entity<Content>().ToTable("Contents");
            //modelBuilder.Entity<Appraise>().ToTable("Appraises");
            //modelBuilder.Entity<Comment>().ToTable("Comments");
            //modelBuilder.Entity<KeyWord>().ToTable("KeyWords");
            base.OnModelCreating(modelBuilder);
        }
    }
}
