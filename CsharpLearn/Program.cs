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
            ////db.Migrate();
            //db.EnsureDeleted();
            //db.EnsureCreated();
            //context.SaveChanges();
        }
    }
}


