
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class Helper
    {
        private static SqlDbContext _context;
        static Helper()
        {
            _context = new SqlDbContext();
        }

        internal static  SqlDbContext GetDbContext() => _context;

        internal static DateTime baseLine = DateTime.Now.AddMonths(-1);

    }
}
