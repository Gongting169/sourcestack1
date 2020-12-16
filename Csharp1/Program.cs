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
            db.Migrate();//类似于update database,会使用还没有被应用的migration，跟新到数据库，本身并不生成Migration文件，是依赖于migration文件的
            db.EnsureDeleted();
            db.EnsureCreated();


            //User user1 = new User()
            //{
            //    Name = "lgy"
            //};
            //dbContext.Users.Add(user1);
            //dbContext.SaveChanges();

        }
    }
}


