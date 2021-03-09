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
            context.SaveChanges();
            Helper.GetDbContext1().Database.Delete();
            Helper.GetDbContext1().Database.Create();

            UserFactory.Creat();

        }
    }
}
