using CSharplearn;
using CSharplearn.ProcedureObject;
using CSharplearn.ProcedureObject.Enum;
using CSharplearn.ProcedureObject.Generic;
using E= sourcestack1.Entity;
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

namespace CSharplearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext dbContext = new SqlDbContext();

            User user1 = new User()
            {
                Name = "lgy"
            };
            dbContext.Users.Add(user1);
            dbContext.SaveChanges();

        }
    }
}


