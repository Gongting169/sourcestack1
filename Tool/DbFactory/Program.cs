using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();
            context.Database.Delete();
            context.Database.Create();

        }
    }
}
