
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
            Helper.GetDbContext().Database.Delete();
            Helper.GetDbContext().Database.Create();
            UserFactory.Creat();

        }
    }
}
