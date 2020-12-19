using CSharplearn;
using CSharplearn.ProcedureObject;
using CSharplearn.ProcedureObject.Enum;
using CSharplearn.ProcedureObject.Generic;
using E = sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static CSharplearn.ProcedureObject.Generic.Generic;
using sourcestack1.Entity;
using CSharplearn.OO.Entity_FrameWork;
using Microsoft.EntityFrameworkCore;

namespace CSharplearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();
            var db = context.Database;

            db.EnsureDeleted();
            db.EnsureCreated();

            //db.Migrate();
            //利用EF，插入3个User对象 
            //User user1 = new User()
            //{
            //    Id = 1,
            //    Name = "lgy",
            //    Password = "1235",
            //    CreateTime=new DateTime(2020,5,27)
            //};
            //User user2 = new User()
            //{
            //    Id = 2,
            //    Name = "马保国",
            //    Password = "2578",
            //    CreateTime =new DateTime(2020,3,8)
            //};
            //User user3 = new User()
            //{
            //    Id = 3,
            //    Name = "我会闪电五连鞭",
            //    Password = "3698",
            //    CreateTime=new DateTime(2020,9,1)
            //};
            //context.Users.Add(user1);
            //context.Add(user3);
            //context.Add<User>(user2);
            //context.SaveChanges();

            //通过Id找到其中一个User对象            
            //User user4 = context.Find<User>("马保国");
            //Console.WriteLine(user4.Name);
            ////修改该User对象的Name属性，将其同步到数据库
            //User user8 = context.Find<User>("lgy");
            //user8.Name = "刘志秀";
            //context.SaveChanges();

            //删除该Id用户
            //User user5 = new User() { Id = 3 };           
            //context.Remove(user5);
            //context.SaveChanges();

            //不加载User对象，仅凭其Id用一句Update SQL语句完成上题 
            //User user6 = new User() { Id = 3 };
            //context.Attach<User>(user6);
            //user6.Name = "真不错";
            //context.SaveChanges();

        }
    }
}


