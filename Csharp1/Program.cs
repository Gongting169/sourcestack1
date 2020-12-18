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
            //var db = context.Database;
            //db.Migrate();
            //db.EnsureDeleted();
            //db.EnsureCreated();

            //利用EF，插入3个User对象 
            //User user1 = new User()
            //{
            //    Name = "lgy",
            //    Password ="1235"
            //};
            //User user = new User()
            //{
            //    Name = "马保国",
            //    Password = "2578"
            //};
            //User user2 = new User()
            //{
            //    Name = "我会闪电五连鞭",
            //    Password = "3698"
            //};
            //context.Users.Add(user1);
            //context.Add(user);
            //context.Add<User>(user2);
            //context.SaveChanges();

            //通过Id找到其中一个User对象 
            User user3 = context.Find<User>("马保国");



        }
    }
}


