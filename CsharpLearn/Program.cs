using CSharplearn;
using CSharplearn.ProcedureObject;
using CSharplearn.ProcedureObject.Enum;
using CSharplearn.ProcedureObject.Generic;
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
using CSharplearn.OO.Entity_FrameWork;
using Microsoft.EntityFrameworkCore;
using CSharplearn.OO.YqBang;

namespace CSharplearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();

            //var db = context.Database;
            //////db.Migrate();
            //db.EnsureDeleted();
            //db.EnsureCreated();

            //context.SaveChanges();

            Article article = new Article()
            {
                Title = "我是谁",
                Body = "明天真美好",
                PublishTime = new DateTime(2020, 8, 5),
                Author =new User() { Id = 1},
                KeyWords= new List<KeyWord>() {  new KeyWord() { Id =1},new KeyWord() { Id =2},new KeyWord() { Id =3} }             
            };
            Article article1 = new Article()
            {
                Title = "马保国练太极",
                Body = "我会闪电五连鞭",
                PublishTime = new DateTime(2020, 10, 1)
            };
            Article article2 = new Article()
            {
                Title = "中级必杀",
                Body = "我会打太极",
                PublishTime = new DateTime(2020, 8, 15)
            };
            //context.AddRange(article,article1,article2 );
            //context.AddRange(content,content1,content2);
            context.SaveChanges();
            //利用EF，插入3个User对象 
            //User user1 = new User()
            //{
            //    Name = "lgy",
            //    Password = "1235",
            //    InvitedCode = 1586,
            //    CreateTime = new DateTime(2020, 5, 27),
            //    EmailId = 1
            //};
            //User user2 = new User()
            //{
            //    Name = "马保国",
            //    Password = "2578",
            //    InvitedCode = 2358,
            //    CreateTime = new DateTime(2020, 3, 8),
            //    EmailId = 2
            //};
            //User user3 = new User()
            //{
            //    Name = "我会闪电五连鞭",
            //    Password = "3698",
            //    InvitedCode = 1586,
            //    CreateTime = new DateTime(2020, 9, 1),
            //    EmailId = 3
            //};
            //context.Users.Add(user1);
            //context.Add(user3);
            //context.Add<User>(user2);
            //context.SaveChanges();

            //Email email = new Email()
            //{
            //    Name = "17832593@qq.com",
            //    Captcha = "yu25",
            //    Enable = true
            //};
            //Email email1 = new Email()
            //{
            //    Name = "1586259@qq.com",
            //    Captcha = "yx85",
            //    Enable = false
            //};
            //Email email2 = new Email()
            //{
            //    Name = "147258369@qq.com",
            //    Captcha = "ts10",
            //    Enable = false
            //};
            //context.AddRange(email2, email1, email);
            //context.SaveChanges();

            //通过name找到其中一个User对象            
            //User user4 = context.Find<User>("马保国");
            //Console.WriteLine(user4.Name);
            //修改该User对象的Name属性，将其同步到数据库
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


