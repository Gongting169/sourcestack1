
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Helper.GetDbContext().Database.Delete();
            Helper.GetDbContext().Database.Create();

            try
            {
                Helper.GetDbContext().Database.BeginTransaction();
                KeywordFactory.Creat();
                ArticleFactory.Create();
                AppraiseFactory.Create();
                CommentFactory.Create();
                UserFactory.Creat();
                Helper.GetDbContext().Database.CurrentTransaction.Commit();

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
